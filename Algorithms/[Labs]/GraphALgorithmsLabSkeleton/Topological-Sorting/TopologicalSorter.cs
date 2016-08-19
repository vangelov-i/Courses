using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

public class TopologicalSorter
{
    private Dictionary<string, List<string>> graph;

    public TopologicalSorter(Dictionary<string, List<string>> graph)
    {
        this.graph = graph;
    }

    //public ICollection<string> TopSort()
    //{
    //    List<string> result = new List<string>();

    //    while (this.graph.Count > 0)
    //    {
    //        string keyToRemove = string.Empty;
    //        foreach (var stringListStringPair in this.graph)
    //        {
    //            bool currentNodeIsDependant = true;
    //            foreach (var kvp in this.graph)
    //            {
    //                if (kvp.Value.Contains(stringListStringPair.Key) && !result.Contains(stringListStringPair.Key))
    //                {
    //                    currentNodeIsDependant = false;
    //                    break;
    //                }
    //            }

    //            if (currentNodeIsDependant)
    //            {
    //                keyToRemove = stringListStringPair.Key;
    //                result.Add(stringListStringPair.Key);
    //                break;
    //            }
    //        }

    //        if (keyToRemove == string.Empty)
    //        {
    //            throw new InvalidOperationException("A cycle detected in the graph");
    //        }

    //        this.graph.Remove(keyToRemove);
    //    }

    //    return result;
    //}

    //working tests
    public ICollection<string> TopSort()
    {
        Dictionary<string, int> predecessorsCount = this.GetPredecessors();

        var removedNodes = new List<string>();

        string nodeToRemove = this.graph.Keys.FirstOrDefault(n => predecessorsCount[n] == 0);
        while (nodeToRemove != null)
        {
            this.RemovePredecessors(nodeToRemove, predecessorsCount);
            this.graph.Remove(nodeToRemove);
            removedNodes.Add(nodeToRemove);

            nodeToRemove = this.graph.Keys.FirstOrDefault(n => predecessorsCount[n] == 0);
        }

        bool graphIsCyclic = this.graph.Count > 0;
        if (graphIsCyclic)
        {
            throw new InvalidOperationException("A cycle detected in the graph");
        }

        return removedNodes;
    }

    private Dictionary<string, int> GetPredecessors()
    {
        var predecessorsCount = new Dictionary<string, int>();

        foreach (var node in this.graph)
        {
            this.AddNode(predecessorsCount, node.Key);

            this.UpdatePredecessorsCount(predecessorsCount, node);
        }

        return predecessorsCount;
    }

    private void AddNode(Dictionary<string, int> predecessorsCount, string node)
    {
        if (!predecessorsCount.ContainsKey(node))
        {
            predecessorsCount[node] = 0;
        }
    }

    private void UpdatePredecessorsCount(Dictionary<string, int> predecessorsCount, KeyValuePair<string, List<string>> node)
    {
        foreach (var childNode in node.Value)
        {
            this.AddNode(predecessorsCount, childNode);

            predecessorsCount[childNode]++;
        }
    }

    private void RemovePredecessors(string nodeToRemove, Dictionary<string, int> predecessorsCount)
    {
        foreach (var node in this.graph[nodeToRemove])
        {
            predecessorsCount[node]--;
        }
    }
}
