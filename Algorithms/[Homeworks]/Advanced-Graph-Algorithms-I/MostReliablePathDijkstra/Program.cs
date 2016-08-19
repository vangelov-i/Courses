using System;
using System.Collections.Generic;
using System.Linq;

using Dijkstra;

class Program
{
    static void Main(string[] args)
    {
        int nodesCount = int.Parse(Console.ReadLine().Substring(7));
        int[] destinations = Console.ReadLine().Substring(5)
            .Split(new []{' ','-'}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sourceNode = destinations[0];
        int destinationNode = destinations[1];

        var nodes = new Dictionary<int, Node>();
        for (int i = 0; i < nodesCount; i++)
        {
            nodes.Add(i, new Node(i));
        }

        var graph = new Dictionary<Node, Dictionary<Node, int>>();

        int edgesCount = int.Parse(Console.ReadLine().Substring(7));
        for (int i = 0; i < edgesCount; i++)
        {
            int[] lineParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startNode = lineParams[0];
            int endNode = lineParams[1];
            int weight = lineParams[2];

            if (!graph.ContainsKey(nodes[startNode]))
            {
                graph.Add(nodes[startNode], new Dictionary<Node, int>());
            }

            if (!graph[nodes[startNode]].ContainsKey(nodes[endNode]))
            {
                graph[nodes[startNode]].Add(nodes[endNode], weight * 1000);
            }

            if (!graph.ContainsKey(nodes[endNode]))
            {
                graph.Add(nodes[endNode], new Dictionary<Node, int>());
            }

            if (!graph[nodes[endNode]].ContainsKey(nodes[startNode]))
            {
                graph[nodes[endNode]].Add(nodes[startNode],  weight * 1000);
            }
        }

        var mostReliablepath = DijkstraAlgorithm(graph, nodes, sourceNode, destinationNode);

        Console.WriteLine("Most reliable path reliability: {0:F2}", nodes[destinationNode].DistanceFromStart / 1000.0);
        Console.WriteLine(string.Join(" -> ", mostReliablepath));
    }

    public static List<int> DijkstraAlgorithm(Dictionary<Node, Dictionary<Node, int>> graph, Dictionary<int, Node> nodes, int sourceNode, int destinationNode)
    {
        int[] previous = new int[graph.Count];
        bool[] visited = new bool[graph.Count];
        PriorityQueue<Node> priorityQueue = new PriorityQueue<Node>();
        var startNode = nodes[sourceNode];
        startNode.DistanceFromStart = 100000;

        for (int i = 0; i < previous.Length; i++)
        {
            previous[i] = -1;
        }

        priorityQueue.Enqueue(startNode);

        while (priorityQueue.Count > 0)
        {
            var currentNode = priorityQueue.ExtractMin();

            if (currentNode.Index == destinationNode)
            {
                break;
            }

            foreach (var edge in graph[currentNode])
            {
                if (!visited[edge.Key.Index])
                {
                    priorityQueue.Enqueue(edge.Key);
                    visited[edge.Key.Index] = true;
                }

                var distance = ((double)currentNode.DistanceFromStart / 100000) * ((double)edge.Value / 100000) * 100000;
                if (distance > edge.Key.DistanceFromStart && edge.Key.Index != sourceNode)
                {
                    edge.Key.DistanceFromStart = (int)distance;
                    previous[edge.Key.Index] = currentNode.Index;
                    priorityQueue.DecreaseKey(edge.Key);
                }
            }
        }

        if (previous[destinationNode] == -1)
        {
            return null;
        }

        List<int> path = new List<int>();
        int current = destinationNode;
        while (current != -1)
        {
            path.Add(current);
            current = previous[current];
        }

        path.Reverse();
        return path;
    }
}