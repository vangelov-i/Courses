using System;
using System.Collections;
using System.Collections.Generic;

public class DoublyLinkedList<T> : IEnumerable<T>
{
    private ListNode<T> head;
    private ListNode<T> tail;

    public int Count { get; private set; }

    public void AddFirst(T element)
    {
        var newHead = new ListNode<T>(element);
        if (this.Count == 0)
        {
            this.head = newHead;
            this.tail = newHead;
            this.Count++;

            return;
        }

        this.head.Prev = newHead;
        newHead.Next = this.head;
        this.head = newHead;

        this.Count++;
    }

    public void AddLast(T element)
    {
        var nodeToAdd = new ListNode<T>(element);
        if (this.Count == 0)
        {
            this.head = nodeToAdd;
            this.tail = nodeToAdd;
            this.Count++;

            return;
        }

        this.tail.Next = nodeToAdd;
        nodeToAdd.Prev = this.tail;

        this.tail = nodeToAdd;

        this.Count++;
    }

    public T RemoveFirst()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("List is empty.");
        }

        var firstElement = this.head.Value;

        this.head = this.head.Next;
        if (this.head != null)
        {
            this.head.Prev = null;
        }
        else
        {
            this.tail = null;
        }

        this.Count--;

        return firstElement;
    }

    public T RemoveLast()
    {
        if (this.tail == null)
        {
            throw new InvalidOperationException("List is empty.");
        }
        
        var element = this.tail.Value;
        if (this.tail.Prev != null)
        {
            var newTail = this.tail.Prev;
            this.tail = newTail;

            this.tail.Next = null;
        }
        else
        {
            this.tail = null;
            this.head = null;
        }

        this.Count--;

        return element;
    }

    public void ForEach(Action<T> action)
    {
        foreach (T element in this)
        {
            action(element);
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        var currentNode = this.head;
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

    public T[] ToArray()
    {
        var result = new T[this.Count];
        int index = 0;
        var currentNode = this.head;
        while (currentNode != null)
        {
            result[index++] = currentNode.Value;
            currentNode = currentNode.Next;
        }
        
        return result;
    }

    private class ListNode<T>
    {
        public ListNode(T element)
        {
            this.Value = element;
        }

        public T Value { get; set; }

        public ListNode<T> Next { get; set; }

        public ListNode<T> Prev { get; set; }
    }
}


class Example
{
    static void Main()
    {
        var list = new DoublyLinkedList<int>();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.AddLast(5);
        list.AddFirst(3);
        list.AddFirst(2);
        list.AddLast(10);
        Console.WriteLine("Count = {0}", list.Count);

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveFirst();
        list.RemoveLast();
        list.RemoveFirst();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");

        list.RemoveLast();

        list.ForEach(Console.WriteLine);
        Console.WriteLine("--------------------");
    }
}
