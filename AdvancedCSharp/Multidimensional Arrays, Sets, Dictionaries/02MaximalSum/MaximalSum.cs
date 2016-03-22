namespace _02MaximalSum
{
    using System;
    using System.Linq;

    public class MaximalSum
    {
        public static void Main()
        {
            string[] dimentions = Console.ReadLine().Split();

            int rows = int.Parse(dimentions[0]);
            int columns = int.Parse(dimentions[1]);

            int[][] matrix = InitializeMatrix(rows, columns);

            int[][] maxSumInnerSquareMatrix = GetMaxSumInnerSquareMatrix(matrix);

            PrintResult(maxSumInnerSquareMatrix);
        }

        private static int[][] GetMaxSumInnerSquareMatrix(int[][] matrix)
        {
            int squareSize = 3;
            int maxSum = int.MinValue;
            int startRowIndex = -1;
            int startColIndex = -1;

            for (int row = 0; row <= matrix.Length - squareSize; row++)
            {
                for (int col = 0; col <= matrix[row].Length - squareSize; col++)
                {
                    int currentSum = 0;

                    for (int innerRow = row; innerRow < row + squareSize; innerRow++)
                    {

                        for (int innerCol = col; innerCol < col + squareSize; innerCol++)
                        {
                            currentSum += matrix[innerRow][innerCol];
                        }
                    }

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        startRowIndex = row;
                        startColIndex = col;
                    }
                }
            }

            int[][] maxSumSquareMatrix = new int[squareSize][];
            for (int row = 0; row < squareSize; row++)
            {
                maxSumSquareMatrix[row] = new int[squareSize];

                for (int col = 0; col < squareSize; col++)
                {
                    maxSumSquareMatrix[row][col] = matrix[startRowIndex + row][startColIndex + col];
                }
            }

            return maxSumSquareMatrix;
        }

        private static int[][] InitializeMatrix(int rows, int columns)
        {
            int[][] matrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] splittedNumbers = Console.ReadLine().Split();
                int[] currentLineNumbers = splittedNumbers.Select(int.Parse).ToArray();

                matrix[row] = new int[columns];

                for (int col = 0; col < columns; col++)
                {
                    matrix[row][col] = currentLineNumbers[col];
                }
            }

            return matrix;
        }

        private static void PrintResult(int[][] matrix)
        {
            int sum = matrix.Sum(i => i.Sum());
            Console.WriteLine("Sum = {0}", sum);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}