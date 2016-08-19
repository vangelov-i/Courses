using System;
using System.Collections.Generic;
using System.Text;

class Snakes
{
    private static char[,] matrix;
    private static ISet<string> snakesFound;
    private static StringBuilder currentPath;
    private static int snakeSize;
    private static ISet<string> rotations = new HashSet<string>();

    static void Main()
    {
        snakeSize = int.Parse(Console.ReadLine());
        matrix = new char[2 * snakeSize + 1, 2 * snakeSize + 1];
        matrix[snakeSize, snakeSize] = 'S';

        snakesFound = new HashSet<string>();
        currentPath = new StringBuilder();
        currentPath.Append('S');

        FindSnakes(snakeSize, snakeSize + 1, 'R');

        Console.WriteLine(string.Join("\r\n", snakesFound));
        Console.WriteLine("Snakes count = " + snakesFound.Count);
    }

    private static void FindSnakes(int row, int col, char direction = 'R')
    {
        if (matrix[row, col] != '\0' && currentPath.Length != 0)
        {
            return;
        }

        if (currentPath.Length == snakeSize)
        {
            if (!rotations.Contains(currentPath.ToString()))
            {
                snakesFound.Add(currentPath.ToString());

                AddRotations(currentPath.ToString());
            }

            return;
        }

        matrix[row, col] = direction;
        currentPath.Append(direction);

        FindSnakes(row, col + 1, 'R');
        FindSnakes(row + 1, col, 'D');
        FindSnakes(row, col - 1, 'L');
        FindSnakes(row - 1, col, 'U');

        currentPath.Remove(currentPath.Length - 1, 1);
        matrix[row, col] = '\0';
    }

    private static void AddRotations(string path)
    {
        rotations.Add(path);

        string rotatedPath = path;

        // TODO: figure out why it's still working the same way with and
        // TODO: without the commented lines. Get it to 100 points!

        //for (int i = 0; i < 4; i++)
        //{
        //    rotatedPath = RotateRight(rotatedPath);
            string flippedHorizontal = FlipHorizontal(rotatedPath);
            //string flippedVertical = FlipVertical(rotatedPath);

            rotations.Add(flippedHorizontal);
            //rotations.Add(flippedVertical);
            //rotations.Add(rotatedPath);

            string reversedPath = Reverse(rotatedPath);
            while (reversedPath[1] != 'R')
            {
                reversedPath = RotateRight(reversedPath);
            }

            rotations.Add(reversedPath);

            reversedPath = Reverse(flippedHorizontal);
            while (reversedPath[1] != 'R')
            {
                reversedPath = RotateRight(reversedPath);
            }

            rotations.Add(reversedPath);

            //reversedPath = Reverse(flippedVertical);
            //while (reversedPath[1] != 'R')
            //{
            //    reversedPath = RotateRight(reversedPath);
            //}

            //rotations.Add(reversedPath);
        //}
    }

    private static string Reverse(string pathToRverse)
    {
        string result = string.Empty;
        result += 'S';

        for (int i = pathToRverse.Length - 1; i >= 0; i--)
        {
            char direction = pathToRverse[i];
            if (direction == 'U')
            {
                result += 'D';
            }
            else if (direction == 'D')
            {
                result += 'U';
            }
            else if (direction == 'L')
            {
                result += 'R';
            }
            else if (direction == 'R')
            {
                result += 'L';
            }
        }

        return result;
    }

    private static string FlipVertical(string pathToFlip)
    {
        string result = string.Empty;

        for (int i = 0; i < pathToFlip.Length; i++)
        {
            char direction = pathToFlip[i];

            if (direction == 'L')
            {
                result += 'R';
            }
            else if (direction == 'R')
            {
                result += 'L';
            }
            else
            {
                result += direction;
            }
        }

        return result;
    }

    private static string FlipHorizontal(string pathToFlip)
    {
        string result = string.Empty;

        for (int i = 0; i < pathToFlip.Length; i++)
        {
            char direction = pathToFlip[i];

            if (direction == 'U')
            {
                result += 'D';
            }
            else if (direction == 'D')
            {
                result += 'U';
            }
            else
            {
                result += direction;
            }
        }

        return result;
    }

    private static string RotateRight(string path)
    {
        string result = string.Empty;
        
        for (int i = 0; i < path.Length; i++)
        {
            char direction = path[i];

            if (direction == 'R')
            {
                result += 'D';
            }
            else if (direction == 'L')
            {
                result += 'U';
            }
            else if (direction == 'U')
            {
                result += 'R';
            }
            else if (direction == 'D')
            {
                result += 'L';
            }
            else
            {
                result += 'S';
            }
        }

        return result;
    }
}