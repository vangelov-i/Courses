using System;
using System.Collections.Generic;
using System.Linq;

public class TopologicalSorter2nd
{
    private Dictionary<string, List<string>> graph;

    public TopologicalSorter2nd(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    //working tests
    public ICollection<string> TopSort()
    {
        Dictionary<string, int> predecessors = new Dictionary<string, int>();

        foreach (var vertexEdgesPair in this.graph)
        {
            if (!predecessors.ContainsKey(vertexEdgesPair.Key))
            {
                predecessors[vertexEdgesPair.Key] = 0;
            }

            foreach (string child in vertexEdgesPair.Value)
            {
                if (!predecessors.ContainsKey(child))
                {
                    predecessors[child] = 0;
                }

                predecessors[child]++;
            }
        }

        var result = new List<string>();

        string nextNode = predecessors.FirstOrDefault(vertexEdgesPair => vertexEdgesPair.Value == 0).Key;
        while (nextNode != null)
        {
            result.Add(nextNode);

            if (this.graph.ContainsKey(nextNode))
            {
                foreach (string child in this.graph[nextNode])
                {
                    predecessors[child]--;
                }
            }

            predecessors.Remove(nextNode);
            nextNode = predecessors.FirstOrDefault(vertexEdgesPair => vertexEdgesPair.Value == 0).Key;
        }

        bool graphIsCyclic = predecessors.Count > 0;
        if (graphIsCyclic)
        {
            throw new InvalidOperationException("A cycle detected in the graph");
        }

        return result;
    }
}
