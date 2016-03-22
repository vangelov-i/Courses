namespace MatrixWalk
{
    using System;

    public class WalkInMatrix
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = Create2DMatrix(size);

            PrintMatrix(matrix);
        }

        public static int[,] Create2DMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            int currentCellValue = 1;
            int currentRow = 0;
            int currentColumn = 0;
            int deltaX = 1;
            int deltaY = 1;

            SetCellToNextValidCell(matrix, out currentRow, out currentColumn);

            while (currentCellValue <= size * size)
            {
                matrix[currentRow, currentColumn] = currentCellValue;

                if (!CheckMatrixHasEmptyCells(matrix, currentRow, currentColumn))
                {
                    SetCellToNextValidCell(matrix, out currentRow, out currentColumn);

                    if (matrix[currentRow, currentColumn] != 0)
                    {
                        break;
                    }
                    else
                    {
                        currentCellValue++;
                        matrix[currentRow, currentColumn] = currentCellValue;
                        deltaX = 1;
                        deltaY = 1;
                    }
                }

                while (currentRow + deltaX >= size ||
                    currentRow + deltaX < 0 ||
                    currentColumn + deltaY >= size ||
                    currentColumn + deltaY < 0 ||
                    matrix[currentRow + deltaX, currentColumn + deltaY] != 0)
                {
                    ChangeDirection(ref deltaX, ref deltaY);
                }

                currentRow += deltaX;
                currentColumn += deltaY;
                currentCellValue++;
            }

            return matrix;
        }

        private static void SetCellToNextValidCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;

            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int column = 0; column < arr.GetLength(1); column++)
                {
                    if (arr[row, column] == 0)
                    {
                        x = row;
                        y = column;

                        return;
                    }
                }
            }
        }

        private static bool CheckMatrixHasEmptyCells(int[,] arr, int x, int y)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < 8; i++)
            {
                if (x + directionsX[i] >= arr.GetLength(0) || x + directionsX[i] < 0)
                {
                    directionsX[i] = 0;
                }

                if (y + directionsY[i] >= arr.GetLength(0) || y + directionsY[i] < 0)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + directionsX[i], y + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void ChangeDirection(ref int dx, ref int dy)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDirection = 0;

            for (int i = 0; i < 8; i++)
            {
                if (directionX[i] == dx && directionY[i] == dy)
                {
                    currentDirection = i;
                    break;
                }
            }

            if (currentDirection == 7)
            {
                dx = directionX[0];
                dy = directionY[0];

                return;
            }

            dx = directionX[currentDirection + 1];
            dy = directionY[currentDirection + 1];
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write("{0,3}", matrix[row, column]);
                }

                Console.WriteLine();
            }
        }
    }
}