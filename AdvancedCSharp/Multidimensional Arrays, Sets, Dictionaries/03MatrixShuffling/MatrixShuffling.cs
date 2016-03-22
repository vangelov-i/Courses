namespace _03MatrixShuffling
{
    using System;

    public class MatrixShuffling
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            string[][] matrix = InitializeMatrix(rows, columns);

            while (true)
            {
                string[] parameters = Console.ReadLine().Split();

                if (parameters[0] == "END")
                {
                    break;
                }

                if (parameters[0] != "swap" || parameters.Length < 5)
                {
                    Console.WriteLine("Invalid input!{0}", Environment.NewLine);
                    continue;
                }

                int firstElementRow = int.Parse(parameters[1]);
                int firstElementCol = int.Parse(parameters[2]);

                int secondElementRow = int.Parse(parameters[3]);
                int secondElementCol = int.Parse(parameters[4]);

                bool rowsAreValid = firstElementRow < rows && secondElementRow < rows;
                bool colsAreValid = firstElementCol < columns && secondElementCol < columns;
                bool positionsAreValid = rowsAreValid && colsAreValid;

                if (positionsAreValid)
                {
                    string firstNumber = matrix[firstElementRow][firstElementCol];
                    string secondNumber = matrix[secondElementRow][secondElementCol];

                    matrix[firstElementRow][firstElementCol] = secondNumber;
                    matrix[secondElementRow][secondElementCol] = firstNumber;

                    Console.WriteLine("(after swapping {0} and {1}):{2}", firstNumber, secondNumber, Environment.NewLine);

                    foreach (string[] strings in matrix)
                    {
                        Console.WriteLine(string.Join(" ", strings));
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!{0}", Environment.NewLine);
                }
            }
        }

        private static string[][] InitializeMatrix(int rows, int columns)
        {
            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new string[columns];

                for (int column = 0; column < columns; column++)
                {
                    string currentElement = Console.ReadLine();

                    matrix[row][column] = currentElement;
                }
            }

            return matrix;
        }
    }
}