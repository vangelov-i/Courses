using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class OrderedSet<T> : IEnumerable<T> where T : IComparable
{
    private Node<T> tree;

    public int Count { get; private set; }

    public void Add(T element)
    {
        if (this.tree == null)
        {
            this.tree = new Node<T>(element);
            this.Count++;
            return;
        }

        var currentNode = this.tree;
        var prevNode = currentNode;
        while (currentNode != null)
        {
            if (element.CompareTo(currentNode.Value) == -1)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new Node<T>(element) { Parent = currentNode };
                    this.Count++;
                    return;
                }

                prevNode = currentNode;
                currentNode = currentNode.Left;
            }
            else if (element.CompareTo(currentNode.Value) == 1)
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new Node<T>(element) { Parent = currentNode };
                    this.Count++;
                    return;
                }

                prevNode = currentNode;
                currentNode = currentNode.Right;
            }
            else
            {
                return;
            }
        }

        currentNode = new Node<T>(element) { Parent = prevNode };
        this.Count++;
    }

    public bool Contains(T element)
    {
        var currentNode = this.tree;
        while (currentNode != null)
        {
            if (element.CompareTo(currentNode.Value) == 0)
            {
                return true;
            }

            if (element.CompareTo(currentNode.Value) == -1)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        return false;
    }

    public void Remove(T element)
    {
        var currentNode = this.tree;
        while (currentNode != null)
        {
            if (element.CompareTo(currentNode.Value) == 0)
            {
                var left = currentNode.Left;
                var right = currentNode.Right;
                if (right != null)
                {
                    currentNode = right;
                }
                else
                {
                    currentNode = left;
                }

                this.Count--;
                return;
            }

            if (element.CompareTo(currentNode.Value) == -1)
            {
                currentNode = currentNode.Left;
            }
            else
            {
                currentNode = currentNode.Right;
            }
        }

        throw new ArgumentException("The given element does not exist.");
    }

    public IEnumerator<T> GetEnumerator()
    {
        var result = new List<T>(this.Count);
        this.GetElementsInOrder(result, this.tree);

        foreach (T element in result)
        {
            yield return element;
        }
    }

    private void GetElementsInOrder(List<T> result, Node<T> node)
    {
        if (node.Left != null)
        {
            this.GetElementsInOrder(result, node.Left);
        }
        
        result.Add(node.Value);

        if (node.Right != null)
        {
            this.GetElementsInOrder(result, node.Right);
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}