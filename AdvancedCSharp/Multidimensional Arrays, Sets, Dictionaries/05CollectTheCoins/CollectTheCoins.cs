namespace _05CollectTheCoins
{
    using System;

    class CollectTheCoins
    {
        static void Main()
        {
            //int rows = int.Parse(Console.ReadLine());
            int rows = 2;

            string[] board = new string[rows];

            for (int row = 0; row < rows; row++)
            {
                board[row] = Console.ReadLine();
            }

            int currentRow = 0;
            int currentCol = 0;
            int lawsHit = 0;
            int collectedCoins = 0;
            bool wallHit = false;

            string command = Console.ReadLine();

            for (int currentCommand = 0; currentCommand < command.Length; currentCommand++)
            {
                wallHit = false;

                switch (command[currentCommand])
                {
                    case 'V':
                        currentRow++;
                        if (currentRow > board.Length - 1 || board[currentRow].Length -1 < currentCol)
                        {
                            currentRow--;
                            lawsHit++;
                            wallHit = true;
                        }

                        break;
                    case '^':
                        currentRow--;
                        if (currentRow < 0 || board[currentRow].Length - 1 < currentCol)
                        {
                            currentRow++;
                            lawsHit++;
                            wallHit = true;
                        }

                        break;
                    case '>':
                        currentCol++;
                        if (currentCol > board[currentRow].Length - 1)
                        {
                            currentCol--;
                            lawsHit++;
                            wallHit = true;
                        }

                        break;
                    case '<':
                        currentCol--;
                        if (currentCol < 0)
                        {
                            currentCol++;
                            lawsHit++;
                            wallHit = true;
                        }

                        break;
                }

                if (!wallHit && board[currentRow][currentCol] == '$')
                {
                    collectedCoins++;
                    board[currentRow] = board[currentRow].Remove(currentCol, 1).Insert(currentCol, "*");
                    Console.WriteLine(board[currentRow]);
                }
            }

            Console.WriteLine("Coins collected: {0}", collectedCoins);
            Console.WriteLine("Walls hit: {0}", lawsHit);
        }
    }
}