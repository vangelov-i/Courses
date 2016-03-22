namespace ConsoleApplication1
{
    using System;

    class Program
    {
        public static void Main(string[] args)
        {
            double[,] firstDoubleMatrix = { { 1, 3 }, { 5, 7 } };

            // for (int i = 0; i < firstDoubleMatrix.GetLength(0); i++)
            // {
            // for (int j = 0; j < firstDoubleMatrix.GetLength(1); j++)
            // {
            // Console.Write(firstDoubleMatrix[i,j] + " ");
            // }
            // Console.WriteLine();
            // }
            // Console.WriteLine();
            double[,] secondDoubleMatrix = { { 4, 2 }, { 1, 5 } };

            // for (int i = 0; i < secondDoubleMatrix.GetLength(0); i++)
            // {
            // for (int j = 0; j < secondDoubleMatrix.GetLength(1); j++)
            // {
            // Console.Write(secondDoubleMatrix[i, j] + " ");
            // }
            // Console.WriteLine();
            // }
            // Console.WriteLine();
            double[,] newMatrix = CombinedSquareMatrix(firstDoubleMatrix, secondDoubleMatrix);

            for (int row = 0; row < newMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < newMatrix.GetLength(1); col++)
                {
                    Console.Write(newMatrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }

        private static double[,] CombinedSquareMatrix(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("Both matrixes must be square matrix.");
            }

            int firstMatrixRows = firstMatrix.GetLength(1);

            double[,] mixedMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int row = 0; row < mixedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < mixedMatrix.GetLength(1); col++)
                {
                    for (int i = 0; i < firstMatrixRows; i++)
                    {
                        double firstMatrixMember = firstMatrix[row, i];
                        double secondMatrixMember = secondMatrix[i, col];

                        mixedMatrix[row, col] += firstMatrixMember * secondMatrixMember;
                    }
                }
            }

            return mixedMatrix;
        }
    }
}