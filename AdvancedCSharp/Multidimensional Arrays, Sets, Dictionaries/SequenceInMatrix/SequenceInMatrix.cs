namespace SequenceInMatrix
{
    using System;

    // TODO: NOT FINISHED!
    public class SequenceInMatrix
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new string[columns];
                string[] elements = Console.ReadLine().Split();

                for (int column = 0; column < columns; column++)
                {
                    matrix[row][column] = elements[column];
                }
            }

            int longestHorizontalSequence = 0;
            int longestVerticalSequence = 0;
            int currentVerticalCount = 1;
            int horizontalStartRow = -1;
            int horizontalStartCol = -1;

            int verticalStartRow = -1;
            int verticalStartCol = -1;

            for (int row = 0, verticalCol = 0; row < rows; row++, verticalCol++)
            {
                int currentHorizontalCount = 1;

                if (row < rows -1 && matrix[row][verticalCol / rows] == matrix[row + 1][verticalCol / rows])
                {
                    currentVerticalCount++;
                }
                else
                {
                    if (longestVerticalSequence < currentVerticalCount)
                    {
                        longestVerticalSequence = currentVerticalCount;
                        verticalStartRow = row - longestVerticalSequence;
                        verticalStartCol = verticalCol / rows;
                    }

                    currentVerticalCount = 1;
                }

                for (int column = 0; column < columns - 1; columns++)
                {
                    if (matrix[row][column] == matrix[row][column + 1])
                    {
                        currentHorizontalCount++;
                    }
                    else
                    {
                        if (longestHorizontalSequence < currentHorizontalCount)
                        {
                            longestHorizontalSequence = currentHorizontalCount;
                            horizontalStartRow = row;
                            horizontalStartCol = column - longestHorizontalSequence;
                        }

                        currentHorizontalCount = 1;
                    }
                }
            }

            if (longestVerticalSequence > longestHorizontalSequence)
            {
                string[] sequence = new string[longestVerticalSequence];
                for (int row = 0; row < longestVerticalSequence; row++)
                {
                    sequence[row] = matrix[verticalStartRow + row][verticalStartCol];
                }

                Console.WriteLine(string.Join(", ", sequence));
            }
        }
    }
}