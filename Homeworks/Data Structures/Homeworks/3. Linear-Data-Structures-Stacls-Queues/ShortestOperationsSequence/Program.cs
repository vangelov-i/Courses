using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] lineParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int start = lineParams[0];
        int end = lineParams[1];

        var result = new Queue<Node<int>>();

        result.Enqueue(new Node<int>(start, null));
        while (result.Count > 0)
        {
            var currentNode = result.Dequeue();
            if (currentNode.Value < end)
            {
                result.Enqueue(new Node<int>(currentNode.Value * 2, currentNode));
                result.Enqueue(new Node<int>(currentNode.Value + 2, currentNode));
                result.Enqueue(new Node<int>(currentNode.Value + 1, currentNode));
            }
            else if (currentNode.Value == end && start != end)
            {
                PrintSolution(currentNode);
                return;
            }
        }

        Console.WriteLine("No solution");
    }

    private static void PrintSolution<T>(Node<T> curretNode)
    {
        var result = new Stack<T>();
        while (curretNode != null)
        {
            result.Push(curretNode.Value);
            curretNode = curretNode.Previous;
        }
        
        Console.WriteLine(string.Join(" -> ", result));
    }

    private class Node<T>
    {
        public Node(T value, Node<T> previous)
        {
            this.Value = value;
            this.Previous = previous;
        }

        public T Value { get; set; }

        public Node<T> Previous { get; set; }
    }
}