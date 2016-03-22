namespace Application2
{
    using System;
    using System.Collections.Generic;

    public class MineSweeper
    {
        private const int MaxPoints = 35;
        private const int DefaultBoardRows = 5;
        private const int DefaultBoardColumns = 10;
        private const int TotalBoardCells = DefaultBoardColumns * DefaultBoardRows;
        private const int DefaultMinesCount = 15;

        private string command;
        private char[,] playingField;
        private char[,] minesPositionsField;
        private int achievedPoints;
        private bool mineExploded;
        private List<Player> playersScore;
        private int row;
        private int column;
        private bool gameStarted;
        private bool playerWonTheGame;


        public MineSweeper()
        {
            this.command = string.Empty;
            this.playingField = CreatePlayingField();
            this.minesPositionsField = PlantMines();
            this.achievedPoints = 0;
            this.mineExploded = false;
            this.playersScore = new List<Player>(6);
            this.row = 0;
            this.column = 0;
            this.gameStarted = false;
            this.playerWonTheGame = false;
        }

        public void Run()
        {
            string command = string.Empty;
            char[,] playingField = CreatePlayingField();
            char[,] minesPositionsField = PlantMines();
            int achievedPoints = 0;
            bool mineExploded = false;
            List<Player> playersScore = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool gameStarted = false;
            bool playerWonTheGame = false;

            do
            {
                if (!gameStarted)
                {
                    Console.WriteLine(
                        "Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki."
                        + " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DrawPlayingField(playingField);
                    gameStarted = true;
                }

                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out column)
                        && row <= playingField.GetLength(0) && column <= playingField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintLeaderboard(playersScore);
                        break;
                    case "restart":
                        playingField = CreatePlayingField();
                        minesPositionsField = PlantMines();
                        DrawPlayingField(playingField);

                        // grum = false;
                        // flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (minesPositionsField[row, column] != '*')
                        {
                            if (minesPositionsField[row, column] == '-')
                            {
                                UpdateFields(playingField, minesPositionsField, row, column);
                                achievedPoints++;
                            }

                            if (achievedPoints == MaxPoints)
                            {
                                playerWonTheGame = true;
                            }
                            else
                            {
                                DrawPlayingField(playingField);
                            }
                        }
                        else
                        {
                            mineExploded = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }

                if (mineExploded)
                {
                    DrawPlayingField(minesPositionsField);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " + "Daj si niknejm: ", achievedPoints);
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, achievedPoints);
                    if (playersScore.Count < 5)
                    {
                        playersScore.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < playersScore.Count; i++)
                        {
                            if (playersScore[i].Score < player.Score)
                            {
                                playersScore.Insert(i, player);
                                playersScore.RemoveAt(playersScore.Count - 1);
                                break;
                            }
                        }
                    }

                    playersScore.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    playersScore.Sort((Player r1, Player r2) => r2.Score.CompareTo(r1.Score));
                    PrintLeaderboard(playersScore);

                    playingField = CreatePlayingField();
                    minesPositionsField = PlantMines();
                    achievedPoints = 0;
                    mineExploded = false;
                    gameStarted = false;
                }

                if (playerWonTheGame)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DrawPlayingField(minesPositionsField);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string playerName = Console.ReadLine();
                    Player player = new Player(playerName, achievedPoints);
                    playersScore.Add(player);
                    PrintLeaderboard(playersScore);
                    playingField = CreatePlayingField();
                    minesPositionsField = PlantMines();
                    achievedPoints = 0;
                    playerWonTheGame = false;
                    gameStarted = false;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void PrintLeaderboard(List<Player> playersInLeaderboard)
        {
            Console.WriteLine("\nTo4KI:");
            if (playersInLeaderboard.Count > 0)
            {
                for (int i = 0; i < playersInLeaderboard.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, playersInLeaderboard[i].Name, playersInLeaderboard[i].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void UpdateFields(char[,] playingField, char[,] minesPositionsFieldField, int row, int column)
        {
            char surroundingMinesCount = GetSurroundingMinesCount(minesPositionsFieldField, row, column);
            minesPositionsFieldField[row, column] = surroundingMinesCount;
            playingField[row, column] = surroundingMinesCount;
        }

        private static void DrawPlayingField(char[,] board)
        {
            int totalRows = board.GetLength(0);
            int totalColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < totalRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < totalColumns; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayingField()
        {
            char[,] board = new char[DefaultBoardRows, DefaultBoardColumns];
            for (int i = 0; i < DefaultBoardRows; i++)
            {
                for (int j = 0; j < DefaultBoardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlantMines()
        {
            char[,] minesPlayingField = new char[DefaultBoardRows, DefaultBoardColumns];

            for (int row = 0; row < DefaultBoardRows; row++)
            {
                for (int col = 0; col < DefaultBoardColumns; col++)
                {
                    minesPlayingField[row, col] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < DefaultMinesCount)
            {
                Random random = new Random();
                int nextRandomMine = random.Next(TotalBoardCells);
                if (!mines.Contains(nextRandomMine))
                {
                    mines.Add(nextRandomMine);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine / DefaultBoardColumns;
                int col = mine % DefaultBoardColumns;
                if (col == 0 && mine != 0)
                {
                    row--;
                    col = DefaultBoardColumns;
                }
                else
                {
                    col++;
                }

                minesPlayingField[row, col - 1] = '*';
            }

            return minesPlayingField;
        }

        private static void smetki(char[,] playingField)
        {
            int kol = playingField.GetLength(0);
            int red = playingField.GetLength(1);

            for (int row = 0; row < kol; row++)
            {
                for (int col = 0; col < red; col++)
                {
                    if (playingField[row, col] != '*')
                    {
                        char surroundingMines = GetSurroundingMinesCount(playingField, row, col);
                        playingField[row, col] = surroundingMines;
                    }
                }
            }
        }

        private static char GetSurroundingMinesCount(char[,] minesPositionsField, int selectedRow, int selectedCol)
        {
            int surroundingMinesCount = 0;
            int rows = minesPositionsField.GetLength(0);
            int columns = minesPositionsField.GetLength(1);

            if (selectedRow - 1 >= 0)
            {
                if (minesPositionsField[selectedRow - 1, selectedCol] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if (selectedRow + 1 < rows)
            {
                if (minesPositionsField[selectedRow + 1, selectedCol] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if (selectedCol - 1 >= 0)
            {
                if (minesPositionsField[selectedRow, selectedCol - 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if (selectedCol + 1 < columns)
            {
                if (minesPositionsField[selectedRow, selectedCol + 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol - 1 >= 0))
            {
                if (minesPositionsField[selectedRow - 1, selectedCol - 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if ((selectedRow - 1 >= 0) && (selectedCol + 1 < columns))
            {
                if (minesPositionsField[selectedRow - 1, selectedCol + 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if ((selectedRow + 1 < rows) && (selectedCol - 1 >= 0))
            {
                if (minesPositionsField[selectedRow + 1, selectedCol - 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            if ((selectedRow + 1 < rows) && (selectedCol + 1 < columns))
            {
                if (minesPositionsField[selectedRow + 1, selectedCol + 1] == '*')
                {
                    surroundingMinesCount++;
                }
            }

            // return char.Parse(surroundingMinesCount.ToString());
            return (char)surroundingMinesCount;
        }

    }
}