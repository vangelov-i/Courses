using System;
using System.Collections.Generic;
using System.Linq;

class ExtendCableNetworkPrim
{
    private static HashSet<int> spanningTreeNodes;
    private static BinaryHeap<Edge> spannngTreeEdges;
    private static int budget;
    private static List<Edge> addedSpanningTreeEdges = new List<Edge>();

    static void Main(string[] args)
    {
        spannngTreeEdges = new BinaryHeap<Edge>();
        spanningTreeNodes = new HashSet<int>();
        var graph = BuildGraph();

        // Start Prim's algorithm from each node not still in the spanning tree
        while (spannngTreeEdges.Count > 0)
        {
            var edge = spannngTreeEdges.ExtractMin();
            if (!spanningTreeNodes.Contains(edge.StartNode) || !spanningTreeNodes.Contains(edge.EndNode))
            {
                Prim(graph, edge);
            }
        }

        addedSpanningTreeEdges.Sort();
        foreach (var edge in addedSpanningTreeEdges)
        {
            Console.WriteLine("{{{0}, {1}}} -> {2}", edge.StartNode, edge.EndNode, edge.Weight);
        }

        Console.WriteLine("Budget used: " +
            addedSpanningTreeEdges.Sum(e => e.Weight));
    }

    private static void Prim(Dictionary<int, List<Edge>> graph, Edge startEdge)
    {
        int startNode = spanningTreeNodes.Contains(startEdge.StartNode)
                    ? startEdge.EndNode
                    : startEdge.StartNode;

        spanningTreeNodes.Add(startNode);
        foreach (var startNodeEdge in graph[startNode])
        {
            spannngTreeEdges.Enqueue(startNodeEdge);
        }

        if (budget - startEdge.Weight >= 0)
        {
            addedSpanningTreeEdges.Add(startEdge); // added by me
            budget -= startEdge.Weight;
        }

        while (spannngTreeEdges.Count > 0)
        {
            var smallestEdge = spannngTreeEdges.ExtractMin();
            if (spanningTreeNodes.Contains(smallestEdge.StartNode) ^
                spanningTreeNodes.Contains(smallestEdge.EndNode))
            {
                var nonTreeNode = spanningTreeNodes.Contains(smallestEdge.StartNode)
                    ? smallestEdge.EndNode
                    : smallestEdge.StartNode;

                if (budget - smallestEdge.Weight >= 0)
                {
                    spannngTreeEdges.Enqueue(smallestEdge);
                    addedSpanningTreeEdges.Add(smallestEdge); // added by me
                    spanningTreeNodes.Add(nonTreeNode);
                    budget -= smallestEdge.Weight;

                    foreach (Edge newEdge in graph[nonTreeNode])
                    {
                        if (newEdge != smallestEdge)
                        {
                            spannngTreeEdges.Enqueue(newEdge);
                        }
                    }
                }
            }
        }
    }

    static Dictionary<int, List<Edge>> BuildGraph()
    {
        budget = int.Parse(Console.ReadLine().Substring(8));
        int nodesCount = int.Parse(Console.ReadLine().Substring(7));
        int edgesCount = int.Parse(Console.ReadLine().Substring(7));

        var edges = new Edge[edgesCount];
        for (int i = 0; i < edges.Length; i++)
        {
            string[] lineParams = Console.ReadLine().Split();
            int startNode = int.Parse(lineParams[0]);
            int endNode = int.Parse(lineParams[1]);
            int weight = int.Parse(lineParams[2]);

            var edgeToAdd = new Edge(startNode, endNode, weight);
            edges[i] = edgeToAdd;

            bool edgeIsConnected = lineParams.Length == 4;
            if (edgeIsConnected)
            {
                spanningTreeNodes.Add(startNode);
                spanningTreeNodes.Add(endNode);
            }

        }

        var graph = new Dictionary<int, List<Edge>>();
        foreach (var edge in edges)
        {
            if (spanningTreeNodes.Contains(edge.StartNode) || spanningTreeNodes.Contains(edge.EndNode))
            {
                spannngTreeEdges.Enqueue(edge);
            }
            if (!graph.ContainsKey(edge.StartNode))
            {
                graph.Add(edge.StartNode, new List<Edge>());
            }
            graph[edge.StartNode].Add(edge);
            if (!graph.ContainsKey(edge.EndNode))
            {
                graph.Add(edge.EndNode, new List<Edge>());
            }
            graph[edge.EndNode].Add(edge);
        }

        return graph;
    }
}