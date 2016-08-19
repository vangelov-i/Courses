using System;
using System.Linq;

class PathsBtwAllVerteciesFloydWarshall
{
    static void Main()
    {
        int nodesCount = int.Parse(Console.ReadLine().Substring(7));
        int edgesCount = int.Parse(Console.ReadLine().Substring(7));

        var distances = new int?[nodesCount, nodesCount];
        for (int vertex = 0; vertex < nodesCount; vertex++)
        {
            distances[vertex, vertex] = 0;
        }

        for (int i = 0; i < edgesCount; i++)
        {
            int[] lineParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startVertex = lineParams[0];
            int endVertex = lineParams[1];
            int distance = lineParams[2];

            distances[startVertex, endVertex] = distance;
            distances[endVertex, startVertex] = distance;
        }

        for (int k = 0; k < nodesCount; k++)
        {
            for (int i = 0; i < nodesCount; i++)
            {
                for (int j = 0; j < nodesCount; j++)
                {
                    if (distances[i, j] == null || distances[i,k] + distances[k,j] < distances[i,j])
                    {
                        distances[i, j] = distances[i, k] + distances[k, j];
                    }
                }
            }
        }

        Console.Write(" ");
        for (int i = 0; i < nodesCount; i++)
        {
            Console.Write("  " + i);
        }

        Console.WriteLine();
        Console.WriteLine(new string('-', edgesCount * 2));

        for (int row = 0; row < nodesCount; row++)
        {
            Console.Write(row + "  ");
            for (int col = 0; col < nodesCount; col++)
            {
                Console.Write((distances[row, col] + "").PadRight(3));
            }
            Console.WriteLine();
        }
    }
}