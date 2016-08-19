using System;
using System.Linq;

class Program
{
    private static int?[,] matrix;
    private static string first;
    private static string second;
    private static string commonPart = string.Empty;

    static void Main(string[] args)
    {
        first = "oke";
        second = "kvobe";

        matrix = new int?[first.Length + 1, second.Length + 1];
        for (int i = 0; i <= first.Length; i++)
        {
            matrix[i, 0] = 0;
        }

        for (int i = 0; i <= second.Length; i++)
        {
            matrix[0, i] = 0;
        }

        int LCS = FindLCS(first.Length, second.Length);
        Console.WriteLine(LCS);
        Console.WriteLine();

        {
            int row = first.Length;
            int col = second.Length;
            while (row > 0 && col > 0)
            {
                if (first[row - 1] == second[col - 1])
                {
                    commonPart += first[row - 1];
                    row--;
                    col--;
                }
                else if (matrix[row-1,col] > matrix[row, col -1])
                {
                    row--;
                }
                else
                {
                    col--;
                }
            }
        }
        Console.WriteLine(new string(commonPart.Reverse().ToArray()));
        Console.WriteLine();

        Console.WriteLine("  " + second);
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row > 0 && row <= first.Length)
            {
                Console.Write(first[row - 1]);
            }
            else
            {
                Console.Write(" ");
            }
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == null)
                {
                    Console.Write("X");
                }
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static int FindLCS(int row, int col)
    {
        if (matrix[row, col] != null)
        {
            return (int)matrix[row, col];
        }

        if (first[row - 1] == second[col - 1])
        {
            matrix[row, col] = FindLCS(row - 1, col - 1) + 1;
        }
        else
        {
            matrix[row, col] = Math.Max(FindLCS(row, col - 1), FindLCS(row - 1, col));
        }

        return (int)matrix[row, col];
    }
}