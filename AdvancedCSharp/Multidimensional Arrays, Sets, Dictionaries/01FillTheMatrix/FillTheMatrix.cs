namespace _01FillTheMatrix
{
    using System;

    public class FillTheMatrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] filledPatternA = FillMatrixPatternA(n);
            int[][] filledPatternB = FillMatrixPatternB(n);

            Console.WriteLine("Matrix filled with pattern A:");
            PrintMatrix(filledPatternA);

            Console.WriteLine(new string('-', n*3));

            Console.WriteLine("Matrix filled with pattern B:");
            PrintMatrix(filledPatternB);
        }

        private static int[][] FillMatrixPatternA(int dimentionsSize)
        {
            int[][] fillPatternA = new int[dimentionsSize][];
            int cellCounter = 1;

            for (int row = 0; row < dimentionsSize; row++)
            {
                fillPatternA[row] = new int[dimentionsSize];
            }

            for (int column = 0; column < dimentionsSize; column++)
            {
                for (int row = 0; row < dimentionsSize; row++)
                {
                    fillPatternA[row][column] = cellCounter++;
                }
            }

            return fillPatternA;
        }

        private static int[][] FillMatrixPatternB(int dimentionsSize)
        {
            int[][] fillMatrixPatternB = new int[dimentionsSize][];

            for (int i = 0; i < dimentionsSize; i++)
            {
                fillMatrixPatternB[i] = new int[dimentionsSize];
            }

            int cellCounter = 1;

            int row = 0;
            int column = 0;

            while (cellCounter <= dimentionsSize * dimentionsSize)
            {
                fillMatrixPatternB[row][column / dimentionsSize] = cellCounter;

                column++;

                if (cellCounter % dimentionsSize != 0)
                {
                    if ((cellCounter / dimentionsSize) % 2 == 1)
                    {
                        row--;
                    }
                    else
                    {
                        row++;
                    }
                }

                cellCounter++;
            }

            return fillMatrixPatternB;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (int[] ints in matrix)
            {
                Console.WriteLine(string.Join(" ", ints));
            }
        }
    }
}
