using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class TopologicalSorterDFS
{
    private Dictionary<string, List<string>> graph;

    public TopologicalSorterDFS(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    private List<string> topSorted;
    private HashSet<string> currentVisited; 
    //working tests
    public ICollection<string> TopSort()
    {
        topSorted = new List<string>();
        this.currentVisited = new HashSet<string>();

        HashSet<string> visitedVertexes = new HashSet<string>();

        foreach (var vertex in this.graph.Keys)
        {
            TopSortDFS(vertex, visitedVertexes);
        }

        this.topSorted.Reverse();

        return this.topSorted;
    }

    private void TopSortDFS(string vertex, HashSet<string> visitedVertexes)
    {
        if (this.currentVisited.Contains(vertex))
        {
            throw new InvalidOperationException("A cycle detected in the graph");
        }

        if (visitedVertexes.Contains(vertex))
        {
            return;
        }

        visitedVertexes.Add(vertex);
        this.currentVisited.Add(vertex);

        if (this.graph.ContainsKey(vertex))
        {
            foreach (string child in this.graph[vertex])
            {
                TopSortDFS(child, visitedVertexes);
            }
        }

        this.currentVisited.Remove(vertex);

        this.topSorted.Add(vertex);
    }
}