using System;
using System.Collections.Generic;
using System.Linq;

class ModifiedKruskal
{
    static void Main(string[] args)
    {
        int nodesCount = int.Parse(Console.ReadLine().Substring(7));
        int edgesCount = int.Parse(Console.ReadLine().Substring(7));

        List<Edge> edges = ParseEdges(edgesCount);

        var minimumSpanningForest = Kruskal(nodesCount, edges);

        foreach (var edge in minimumSpanningForest)
        {
            Console.WriteLine("({0} {1}) -> {2}", edge.StartNode, edge.EndNode, edge.Weight);
        }
    }

    private static List<Edge> ParseEdges(int edgesCount)
    {
        var result = new List<Edge>();

        for (int i = 0; i < edgesCount; i++)
        {
            int[] lineParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int startNode = lineParams[0];
            int endtNode = lineParams[1];
            int weight = lineParams[2];

            var edge = new Edge(startNode, endtNode, weight);
            result.Add(edge);
        }

        return result;
    }

    public static List<Edge> Kruskal(int numberOfVertices, List<Edge> edges)
    {
        List<Edge> spanningTree = new List<Edge>();
        edges.Sort();

        // Initialize parents
        int[] parent = new int[numberOfVertices];
        for (int i = 0; i < numberOfVertices; i++)
        {
            parent[i] = i;
        }

        foreach (Edge edge in edges)
        {
            int startNodeRoot = FindRoot(edge.StartNode, parent);
            int endNodeRoot = FindRoot(edge.EndNode, parent);

            if (startNodeRoot != endNodeRoot)
            {
                parent[startNodeRoot] = endNodeRoot;
                spanningTree.Add(edge);
            }
        }

        return spanningTree;
    }

    static int FindRoot(int node, int[] parent)
    {
        // Find the root parent for the node
        int root = node;
        while (parent[root] != root)
        {
            root = parent[root];
        }

        // Optimize(compress) the path from node to root
        while (node != root)
        {
            var oldParent = parent[node];
            parent[node] = root;
            node = oldParent;
        }

        return root;
    }

}