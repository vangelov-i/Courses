using System;

class Program
{
    static void Main(string[] args)
    {
        int cases = int.Parse(Console.ReadLine());
        for (int i = 0; i < cases; i++)
        {
            int matrixRows = int.Parse(Console.ReadLine().Split()[0]);
            string[] matrix = new string[matrixRows];
            for (int row = 0; row < matrixRows; row++)
            {
                matrix[row] = Console.ReadLine();
            }

            int patternRows = int.Parse(Console.ReadLine().Split()[0]);
            string[] pattern = new string[patternRows];
            for (int row = 0; row < patternRows; row++)
            {
                pattern[row] = Console.ReadLine();
            }

            int colIndex = -1;
            int patternRow = 0;
            bool matrixContainsPattern = false;
            int lastColIndex = -1;

            for (int row = 0; row < matrixRows; row++)
            {
                colIndex = matrix[row].IndexOf(pattern[patternRow]);
                if (colIndex == -1 && patternRow != 0)
                {
                    patternRow = 0;
                }
                else if (colIndex != -1)
                {
                    if (colIndex != lastColIndex && patternRow != 0)
                    {
                        patternRow = 0;
                        colIndex = -1;
                        lastColIndex = -1;
                    }
                    else
                    {
                        patternRow++;
                    }
                }

                lastColIndex = colIndex;
                if (patternRow == patternRows)
                {
                    matrixContainsPattern = true;
                    break;
                }
            }

            if (matrixContainsPattern)
            {
                Console.WriteLine();
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO");
            }
        }
    }
}