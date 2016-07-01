using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

class LongestPathInTree
{
    private static HashSet<Node<int>> visited;

    static void Main()
    {
        int nodesCount = int.Parse(Console.ReadLine());
        int edgesCount = int.Parse(Console.ReadLine());
        var nodes = new Dictionary<int, Node<int>>();

        for (int i = 0; i < edgesCount; i++)
        {
            int[] currentEdgeNodes =
                Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstNodeValue = currentEdgeNodes[0];
            int secondNodeValue = currentEdgeNodes[1];


            if (!nodes.ContainsKey(firstNodeValue))
            {
                nodes[firstNodeValue] = new Node<int>(firstNodeValue);
            }

            if (!nodes.ContainsKey(secondNodeValue))
            {
                nodes[secondNodeValue] = new Node<int>(secondNodeValue);
            }

            var firstNode = nodes[firstNodeValue];
            var secondtNode = nodes[secondNodeValue];

            firstNode.Children.Add(secondtNode);
            secondtNode.Parent = firstNode;
        }

        var leaves = nodes.Values.Where(n => n.IsLeaf);
        visited = new HashSet<Node<int>>();
        int maxDistance = int.MinValue;

        foreach (var leaf in leaves)
        {
            visited.Add(leaf);
            startLeafMaxDistance = int.MinValue;

            Dfs(leaf, leaf.Value);

            visited.Clear();
            //visited.Add(leaf);

            if (maxDistance < startLeafMaxDistance)
            {
                maxDistance = startLeafMaxDistance;
            }
        }

        Console.WriteLine(maxDistance);
    }

    private static int startLeafMaxDistance;

    private static void Dfs(Node<int> node, int currentDistance)
    {
        if (node.IsLeaf && startLeafMaxDistance < currentDistance)
        {
            startLeafMaxDistance = currentDistance;
        }

        foreach (var child in node.Children)
        {
            if (!visited.Contains(child))
            {
                visited.Add(child);
                Dfs(child, currentDistance + child.Value);
            }
        }

        if (node.Parent != null && !visited.Contains(node.Parent))
        {
            visited.Add(node.Parent);
            Dfs(node.Parent, currentDistance + node.Parent.Value);
        }
    }
}

class Node<T>
{
    public Node(T value)
    {
        this.Value = value;
        this.Children = new List<Node<T>>();
    }

    public T Value { get; set; }

    public Node<T> Parent { get; set; }

    public IList<Node<T>> Children { get; set; }

    public bool IsLeaf => this.Children.Count == 0;
}