using System;
using System.Collections.Generic;
using System.Linq;

class CyclesInGraph
{
    private static IDictionary<char, List<char>> graph;
    private static ISet<char> visitedNodes;
    private static Dictionary<char, int> predecessorsCount;

    static void Main(string[] args)
    {
        predecessorsCount = new Dictionary<char, int>();
        graph = ParseGraph();
        visitedNodes = new HashSet<char>();

        char startNode = predecessorsCount.FirstOrDefault(node => node.Value == 0).Key;

        if (startNode != '\0')
        {
            CheckGraphForCycles(startNode);
        }

        Console.Write("Acyclic: ");
        if (visitedNodes.Count != graph.Count || visitedNodes.Count == 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
    }

    private static void CheckGraphForCycles(char node)
    {
        if (visitedNodes.Contains(node))
        {
            return;
        }

        visitedNodes.Add(node);
        if (graph.ContainsKey(node))
        {
            foreach (var childNode in graph[node])
            {
                CheckGraphForCycles(childNode);
            }
        }
    }

    private static IDictionary<char, List<char>> ParseGraph()
    {
        var result = new Dictionary<char, List<char>>();

        string currentLine = Console.ReadLine();
        while (!string.IsNullOrEmpty(currentLine))
        {
            char node = currentLine[0];
            if (!predecessorsCount.ContainsKey(node))
            {
                predecessorsCount[node] = 0;
            }

            char childNode = currentLine[currentLine.LastIndexOf(' ') + 1];

            if (!predecessorsCount.ContainsKey(childNode))
            {
                predecessorsCount[childNode] = 0;
            }

            if (!result.ContainsKey(childNode))
            {
                result[childNode] = new List<char>();
            }

            if (!result.ContainsKey(node))
            {
                result[node] = new List<char>();
            }

            result[node].Add(childNode);
            predecessorsCount[childNode]++;

            currentLine = Console.ReadLine();
        }

        return result;
    }
}