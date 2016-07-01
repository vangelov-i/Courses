using System;
using System.Collections.Generic;
using System.Linq;

class FindTheRoot
{
    static void Main()
    {
        var nodes = new Dictionary<int, List<int>>();

        int nodesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < nodesCount; i++)
        {
            nodes[i] = new List<int>();
        }

        var children = new HashSet<int>();
        int edgesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < edgesCount; i++)
        {
            int[] currentEdgeNodes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int parent = currentEdgeNodes[0];
            int child = currentEdgeNodes[1];

            nodes[parent].Add(child);
            children.Add(child);
        }

        if (children.Count == nodes.Count)
        {
            Console.WriteLine("No root!");
        }
        else if (children.Count == nodes.Count - 1)
        {
            int root = nodes.FirstOrDefault(n => !children.Contains(n.Key)).Key;
            Console.WriteLine(root);
        }
        else
        {
            Console.WriteLine("Multiple root nodes!");
        }
    }
}