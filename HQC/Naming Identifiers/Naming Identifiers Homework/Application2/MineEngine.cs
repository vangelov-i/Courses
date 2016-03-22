using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application2
{
    class MineEngine
    {
        private MineSweeper minesGame;

        public MineEngine()
        {
            this.minesGame = new MineSweeper();
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

    }
}
