using System;
using System.Collections;
using System.Collections.Generic;

class RideTheHorse
{
    private static int[,] board;

    static void Main()
    {
        int totalRows = int.Parse(Console.ReadLine());
        int totalCols = int.Parse(Console.ReadLine());

        int startRow = int.Parse(Console.ReadLine());
        int startCol = int.Parse(Console.ReadLine());

        board = new int[totalRows,totalCols];
        board[startRow, startCol] = 1;

        BfsHorseMovement(startRow, startCol);

        int middleCol = totalCols / 2;
        for (int row = 0; row < totalRows; row++)
        {
            Console.WriteLine(board[row, middleCol]);
        }
    }

    private static void BfsHorseMovement(int row, int col)
    {
        var nextPositions = new Queue<Tuple<int, int>>();
        nextPositions.Enqueue(new Tuple<int, int>(row, col));
        int[] offsets = { -2, 1, -1, 2, 1, 2, 2, 1, 2, -1, 1, -2, -1, -2, -2, -1 };

        while (nextPositions.Count > 0)
        {
            var currentPosition = nextPositions.Dequeue();
            int currentRow = currentPosition.Item1;
            int currentCol = currentPosition.Item2;

            for (int index = 0; index < 16; index += 2)
            {
                int nextRow = currentRow + offsets[index];
                int nextCol = currentCol + offsets[index + 1];

                bool positionIsValid = 
                    ValidatePosition(nextRow, nextCol) && 
                    board[nextRow, nextCol] == 0;

                if (positionIsValid)
                {
                    board[nextRow, nextCol] = board[currentRow, currentCol] + 1;
                    nextPositions.Enqueue(new Tuple<int, int>(nextRow, nextCol));
                }
            }
        }
    }

    public static bool ValidatePosition(int row, int col)
    {
        bool rowIsValid = row >= 0 && row < board.GetLength(0);
        bool colIsValid = col >= 0 && col < board.GetLength(1);

        return rowIsValid && colIsValid;
    }
}