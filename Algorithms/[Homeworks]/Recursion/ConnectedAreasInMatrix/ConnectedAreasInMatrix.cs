namespace ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ConnectedAreasInMatrix
    {
        //private static char[,] matrix =
        //    {
        //        { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', },
        //        { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', },
        //        { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', },
        //        { ' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' ', },
        //    };

        private static char[,] matrix =
            {
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' '},
                { '*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' '},
                { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' ', ' '},
            };

        private static Dictionary<string, int> connectedAreas = new Dictionary<string, int>();
        private static int currrentAreaCount;

        static void Main(string[] args)
        {
            int[] freeCellPos = FindNextFreeCell(matrix);

            while (freeCellPos[0] != -1)
            {
                FindConnectedArea(matrix, freeCellPos[0], freeCellPos[1]);

                connectedAreas[freeCellPos[0] + ", " + freeCellPos[1]] = currrentAreaCount;
                currrentAreaCount = 0;

                freeCellPos = FindNextFreeCell(matrix);
            }

            PrintColoredAreas();
            PrintResult();
        }

        private static void FindConnectedArea(char[,] marix, int row, int col)
        {
            if (!ValidatePosition(marix, row, col) || marix[row, col] != ' ')
            {
                return;
            }

            currrentAreaCount++;
            //marix[row, col] = '.';
            marix[row, col] = connectedAreas.Count.ToString()[0];

            FindConnectedArea(marix, row, col - 1);
            FindConnectedArea(marix, row - 1, col);
            FindConnectedArea(marix, row, col + 1);
            FindConnectedArea(marix, row + 1, col);
        }

        private static bool ValidatePosition(char[,] marix, int row, int col)
        {
            bool rowIsValid = row >= 0 && row < marix.GetLength(0);
            bool colIsValid = col >= 0 && col < marix.GetLength(1);

            return rowIsValid && colIsValid;
        }

        private static int[] FindNextFreeCell(char[,] marix)
        {
            int[] freeCellPosition = { -1, -1 };

            for (int currentRow = 0; currentRow < marix.GetLength(0); currentRow++)
            {
                for (int currentCol = 0; currentCol < marix.GetLength(1); currentCol++)
                {
                    if (marix[currentRow, currentCol] == ' ')
                    {
                        freeCellPosition[0] = currentRow;
                        freeCellPosition[1] = currentCol;

                        return freeCellPosition;
                    }
                }
            }

            return freeCellPosition;
        }

        private static void PrintResult()
        {
            Console.WriteLine("Total areas found: {0}", connectedAreas.Count);

            int areaCount = 1;
            foreach (var areaCountPair in connectedAreas.OrderByDescending(kv => kv.Value).ThenBy(kv => kv.Key))
            {
                Console.WriteLine(
                    "Area #{0} at ({1}), size: {2}",
                    areaCount++,
                    areaCountPair.Key,
                    areaCountPair.Value);
            }
        }

        private static void PrintColoredAreas()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (char.IsDigit(matrix[row, col]))
                    {
                        int color = (int.Parse(matrix[row, col] + "") + 11) % 16;
                        Console.ForegroundColor = (ConsoleColor)color;
                        Console.Write('+');
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(matrix[row, col]);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}