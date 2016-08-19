using System;
using System.Collections.Generic;

class AreasInMatrix
{
    private static int totalRows;
    private static string[] matrix;
    private static bool[,] visitedCells;
    private static IDictionary<char, int> neighbourAreas;
     
    static void Main(string[] args)
    {
        string rowsLine = Console.ReadLine();
        totalRows = int.Parse(rowsLine.Substring(rowsLine.LastIndexOf(' ')));

        matrix = GenerateMatrix(totalRows);
        visitedCells = new bool[totalRows, matrix[0].Length];
        neighbourAreas = new SortedDictionary<char, int>();
        int totalAreas = 0;

        for (int row = 0; row < totalRows; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                if (!visitedCells[row,col])
                {
                    char currentArea = matrix[row][col];
                    neighbourAreas[currentArea] = neighbourAreas.ContainsKey(currentArea) ? 
                        neighbourAreas[currentArea] + 1 : 1;

                    TraverseConnectedArea(currentArea, row, col);
                    totalAreas++;
                }
            }
        }

        Console.WriteLine("Areas: " + totalAreas);
        foreach (var areCountPair in neighbourAreas)
        {
            Console.WriteLine("Letter '{0}' -> {1}", areCountPair.Key, areCountPair.Value);
        }
    }

    private static void TraverseConnectedArea(char areaSign, int row, int col)
    {
        bool positionIsInRange = ValidatePosition(row, col);
        if (!positionIsInRange || matrix[row][col] != areaSign || visitedCells[row, col])
        {
            return;
        }

        visitedCells[row, col] = true;

        TraverseConnectedArea(areaSign, row - 1, col);
        TraverseConnectedArea(areaSign, row, col + 1);
        TraverseConnectedArea(areaSign, row + 1, col);
        TraverseConnectedArea(areaSign, row, col - 1);
    }

    private static bool ValidatePosition(int row, int col)
    {
        bool rowIsValid = row >= 0 && row < matrix.Length;
        bool colIsValid = col >= 0 && col < matrix[0].Length;

        return rowIsValid && colIsValid;
    }

    private static string[] GenerateMatrix(int totalRows)
    {
        string[] result = new string[totalRows];
        for (int i = 0; i < totalRows; i++)
        {
            result[i] = Console.ReadLine();
        }

        return result;
    }
}