using System;
using System.Collections.Generic;
using System.Linq;

class PlayWithTrees
{
    static void Main()
    {
        int pairsCount = int.Parse(Console.ReadLine()) - 1;

        var nodes = new Dictionary<int, Tree<int>>();

        ParseTree(pairsCount, nodes);

        var rootNode = nodes.Values.FirstOrDefault(t => t.Parent == null);
        Console.WriteLine("Root node: {0}", rootNode.Value);

        var leaves = new List<int>();
        rootNode.EachLeafInOrder(leaves.Add);
        Console.WriteLine("Leaf nodes: {0}", string.Join(", ", leaves.OrderBy(l => l)));

        PrintLongestPath(nodes, leaves);

        int pathTargetSum = int.Parse(Console.ReadLine());
        PrintPathsWithTargetSum(nodes, leaves, pathTargetSum);

        int subTreeTargetSum = int.Parse(Console.ReadLine());
        // TODO: not sure what a subtree is. Is 1->19<-12 a valid subtree when 31 is
        // 19's child too.
        //var subTreesSums = new Dictionary<int, int>();
    }

    private static void ParseTree(int pairsCount, Dictionary<int, Tree<int>> nodes)
    {
        for (int i = 0; i < pairsCount; i++)
        {
            int[] pairParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int parent = pairParams[0];
            int child = pairParams[1];

            Tree<int> parentTree = null;
            Tree<int> childTree = null;

            if (!nodes.ContainsKey(child))
            {
                childTree = new Tree<int>(child);
                nodes.Add(child, childTree);
            }

            if (!nodes.ContainsKey(parent))
            {
                parentTree = new Tree<int>(parent);
                nodes.Add(parent, parentTree);
            }

            nodes[parent].Children.Add(nodes[child]);
            nodes[child].Parent = nodes[parent];
        }
    }

    private static void PrintPathsWithTargetSum(Dictionary<int, Tree<int>> nodes, List<int> leaves, int pathTargetSum)
    {
        var visited = new HashSet<int>();
        var nodesToVisit = new Queue<Tree<int>>();

        Console.WriteLine("Paths of sum {0}:", pathTargetSum);

        bool targetSumExists = false;
        foreach (var leaf in leaves)
        {
            nodesToVisit.Enqueue(nodes[leaf]);

            while (nodesToVisit.Count > 0)
            {
                var currentNode = nodesToVisit.Dequeue();
                visited.Add(currentNode.Value);

                var currentPath = new Stack<int>();
                var currentSum = 0;
                while (currentNode != null && currentSum < pathTargetSum)
                {
                    if (!visited.Contains(currentNode.Value))
                    {
                        visited.Add(currentNode.Value);
                        nodesToVisit.Enqueue(currentNode);
                    }

                    currentPath.Push(currentNode.Value);
                    currentSum += currentNode.Value;
                    currentNode = currentNode.Parent;
                }

                if (currentSum == pathTargetSum)
                {
                    targetSumExists = true;
                    Console.WriteLine(string.Join(" -> ", currentPath));
                }
            }
        }

        if (!targetSumExists)
        {
            Console.WriteLine("None");
        }
    }

    private static void PrintLongestPath(Dictionary<int, Tree<int>> nodes, List<int> leaves)
    {
        var longestPath = new List<int>();
        Tree<int> maxLevelLeftMostLeaf = null;
        int maxLevel = 0;
        foreach (int leaf in leaves)
        {
            if (maxLevel < nodes[leaf].Level)
            {
                maxLevel = nodes[leaf].Level;
                maxLevelLeftMostLeaf = nodes[leaf];
            }
        }

        var currentTree = maxLevelLeftMostLeaf;
        while (currentTree != null)
        {
            longestPath.Add(currentTree.Value);
            currentTree = currentTree.Parent;
        }

        longestPath.Reverse();
        Console.WriteLine("Longest path:");
        Console.WriteLine("{0} (length = {1})", string.Join(" -> ", longestPath), maxLevel);
    }
}

class Tree<T>
{
    private int level;
    private int sum;

    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = new List<Tree<T>>();
        foreach (var child in children)
        {
            this.Children.Add(child);
            child.Parent = this;
        }
    }

    public Tree<T> Parent { get; set; }

    public T Value { get; set; }

    public IList<Tree<T>> Children { get; set; }

    public int Level
    {
        get
        {
            if (this.Parent == null)
            {
                this.level = 1;
                return this.level;
            }

            if (this.level == 0)
            {
                this.level = this.Parent.Level + 1;
            }

            return this.level;
        }
    }

    public void EachLeafInOrder(Action<T> action)
    {
        if (this.Children.Count == 0)
        {
            action(this.Value);
            return;
        }

        foreach (var child in this.Children)
        {
            child.EachLeafInOrder(action);
        }
    }

    public void EachPreOrder(Action<T> action)
    {
        action(this.Value);
        foreach (var child in this.Children)
        {
            action(child.Value);
        }
    }
}