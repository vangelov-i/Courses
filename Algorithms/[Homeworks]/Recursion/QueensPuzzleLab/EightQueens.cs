using System;

class EightQueens
{
    const int ChessboardSize = 8;

    static bool[,] chessboard = new bool[ChessboardSize, ChessboardSize];
    static bool[] attackedColums = new bool[ChessboardSize];
    static bool[] attackedLeftDiagonals = new bool[ChessboardSize * 2 - 1];
    static bool[] attackedRightDiagonals = new bool[ChessboardSize * 2 - 1];

    static int solutionsFound;

    static void Main(string[] args)
    {
        PutQueens(0);
    }

    static void PutQueens(int row)
    {
        if (row == ChessboardSize)
        {
            solutionsFound++;
            PrintSolution();
        }
        else
        {
            for (int col = 0; col < ChessboardSize; col++)
            {
                if (CanPlaceQueen(row, col))
                {
                    MarkAllAttackedPositions(row, col);
#if DEBUG_MODE
                    PrintSolution();
#endif

                    PutQueens(row + 1);
                    UnmarkAllAttackedPositions(row, col);
#if DEBUG_MODE
                    PrintSolution();
#endif
                }
            }
        }
    }

    private static bool CanPlaceQueen(int row, int col)
    {
        bool result =
            !attackedColums[col] &&
            !attackedRightDiagonals[row + col] &&
            !attackedLeftDiagonals[col - row + ChessboardSize - 1];

        return result;
    }

    private static void MarkAllAttackedPositions(int row, int col)
    {
        attackedColums[col] = true;
        attackedRightDiagonals[row + col] = true;
        attackedLeftDiagonals[col - row + ChessboardSize - 1] = true;
        chessboard[row, col] = true;
    }

    private static void UnmarkAllAttackedPositions(int row, int col)
    {
        attackedColums[col] = false;
        attackedRightDiagonals[row + col] = false;
        attackedLeftDiagonals[col - row + ChessboardSize - 1] = false;
        chessboard[row, col] = false;
    }


    private static void PrintSolution()
    {
        Console.WriteLine("Solution No: " + solutionsFound);
        int[] colsIndexes = { 0, 1, 2, 3, 4, 5, 6, 7 };
        Console.WriteLine("  " + string.Join(" ", colsIndexes));

        for (int row = 0; row < ChessboardSize; row++)
        {
            Console.Write(row + " ");

            for (int col = 0; col < ChessboardSize; col++)
            {
                if (chessboard[row, col])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("* ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    if (!CanPlaceQueen(row, col))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("x ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}