using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    private static Dictionary<int, List<int>> nodes;
    private static Dictionary<int, int> distances;
    private static HashSet<int> visited;

    static void Main()
    {
        int connectionsCount = int.Parse(Console.ReadLine());
        int root = int.Parse(Console.ReadLine());

        nodes = new Dictionary<int, List<int>>();
        for (int i = 0; i < connectionsCount; i++)
        {
            int[] edgeNodes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstFriend = edgeNodes[0];
            int secondFriend = edgeNodes[1];

            if (!nodes.ContainsKey(firstFriend))
            {
                nodes[firstFriend] = new List<int>();
            }

            if (!nodes.ContainsKey(secondFriend))
            {
                nodes[secondFriend] = new List<int>();
            }

            nodes[firstFriend].Add(secondFriend);
            nodes[secondFriend].Add(firstFriend);
        }


        distances = new Dictionary<int, int>();
        distances[root] = 1;
        visited = new HashSet<int>();

        Dfs(root);

        int longestDancePeopleCount = distances.OrderByDescending(n => n.Value).First().Value;

        Console.WriteLine(longestDancePeopleCount);
    }

    private static void Dfs(int node)
    {
        visited.Add(node);
        foreach (int child in nodes[node])
        {
            if (!visited.Contains(child))
            {
                distances[child] = distances[node] + 1;
                Dfs(child);
            }
        }
    }
}