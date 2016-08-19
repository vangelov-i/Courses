using System;
using System.Collections.Generic;
using System.Collections;

class SinglyLinkedList<T> : IEnumerable<T> where T : IComparable
{
    private ListNode<T> head;
    private ListNode<T> last;

    public int Count { get; private set; }

    public void Add(T item)
    {
        var nodeToAdd = new ListNode<T>(item);
        if (this.Count == 0)
        {
            this.head = nodeToAdd;
            this.last = nodeToAdd;
            this.Count++;

            return;
        }

        this.last.Next = nodeToAdd;
        this.last = nodeToAdd;
        this.Count++;
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException("Index is outside the boundaries of the list.");
        }

        ListNode<T> nodeToRemove = this.head;

        if (index == 0)
        {
            this.head = this.head.Next;
            nodeToRemove = null;
            return;
        }

        int currentIndex = 0;
        ListNode<T> prevNode = this.head;
        while (currentIndex < index)
        {
            prevNode = nodeToRemove;
            nodeToRemove = nodeToRemove.Next;
            currentIndex++;
        }

        prevNode.Next = nodeToRemove.Next;
        nodeToRemove = null;
    }

    public int FirstIndexOf(T item)
    {
        int currentIndex = 0;
        ListNode<T> currentNode = this.head;
        while (currentIndex < this.Count && currentNode.Value.CompareTo(item) != 0)
        {
            currentNode = currentNode.Next;
            currentIndex++;
        }

        currentIndex = currentIndex == this.Count ? -1 : currentIndex;

        return currentIndex;
    }

    public int LastIndexOf(T item)
    {
        int currentIndex = 0;
        int lastIndex = -1;
        ListNode<T> currentNode = this.head;
        while (currentIndex < this.Count)
        {
            if (currentNode.Value.CompareTo(item) == 0)
            {
                lastIndex = currentIndex;
            }

            currentNode = currentNode.Next;
            currentIndex++;
        }

        return lastIndex;
    }

    public IEnumerator<T> GetEnumerator()
    {
        ListNode<T> currentNode = this.head;
        while (currentNode != null)
        {
            yield return currentNode.Value;
            currentNode = currentNode.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }

        public ListNode<T> Next { get; set; }

        public T Value { get; set; }
    }
}