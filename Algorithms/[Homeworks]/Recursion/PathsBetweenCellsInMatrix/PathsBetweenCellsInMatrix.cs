namespace PathsBetweenCellsInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PathsBetweenCellsInMatrix
    {
        private static char[][] matrix = new char[5][];
        private static int pathsFound;
        private static List<char> directions = new List<char>();

        static void Main(string[] args)
        {
            int startRow = -1;
            int startCol = -1;

            for (int i = 0; i < 5; i++)
            {
                // inputyt ima nqkakvi tabulacii, koito taka i ne uspqvam da podmenq s .Replace
                // izpolzvai inputite ot test01.txt i test02.txt v papkata na solution-a. Syshtite
                // sa kakto ot primera, prosto praznite mesta naistina sa ' ' . Plesnah i oshte 2 testa
                string currentLine = Console.ReadLine().Replace('\t', ' ');
                if (currentLine.IndexOf('s') != -1)
                {
                    startRow = i;
                    startCol = currentLine.IndexOf('s');
                }

                matrix[i] = currentLine.ToCharArray();
            }

            FindExit(startRow, startCol, 'S');
            Console.WriteLine("Total paths found: " + pathsFound);
        }

        private static void FindExit(int row, int col, char direction)
        {
            if (!ValidatePositions(row, col))
            {
                return;
            }

            if (matrix[row][col] == 'e')
            {
                directions.Add(direction);
                Console.WriteLine(string.Join("", directions.Skip(1)));
                directions.RemoveAt(directions.Count - 1);

                // printing the path through the matrix:
                PrintPathInMatrix();

                pathsFound++;
                return;
            }

            if (matrix[row][col] != ' ' && directions.Contains('S'))
            {
                return;
            }

            if (matrix[row][col] != 's')
            {
                matrix[row][col] = '.';
            }

            directions.Add(direction);

            FindExit(row, col - 1, 'L');
            FindExit(row, col + 1, 'R');
            FindExit(row - 1, col, 'U');
            FindExit(row + 1, col, 'D');

            matrix[row][col] = ' ';
            directions.RemoveAt(directions.Count - 1);
        }

        private static bool ValidatePositions(int row, int col)
        {
            bool rowIsValid = row >= 0 && row < matrix.Length;
            bool colIsValid = false;

            if (rowIsValid)
            {
                colIsValid = col >= 0 && col < matrix[row].Length;
            }

            return rowIsValid && colIsValid;
        }

        private static void PrintPathInMatrix()
        {
            foreach (var rowArr in matrix)
            {
                foreach (char symbol in rowArr)
                {
                    if (symbol == '.')
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(symbol);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 20));
        }
    }
}
