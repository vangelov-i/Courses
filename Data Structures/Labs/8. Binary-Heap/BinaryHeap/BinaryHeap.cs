using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BinaryHeap<T> where T : IComparable<T>
{
    private IList<T> heap;

    public BinaryHeap()
    {
        this.heap = new List<T>();
    }

    public BinaryHeap(T[] elements)
    {
        this.heap = new List<T>(elements);
        for (int i = this.Count / 2; i >= 0; i--)
        {
            this.HeapifyDown(i);
        }
    }

    public int Count => this.heap.Count;

    public T ExtractMax()
    {
        T maxElement = this.heap[0];
        this.heap[0] = this.heap[this.Count - 1];
        this.heap.RemoveAt(this.Count - 1);
        if (this.Count > 0)
        {
            this.HeapifyDown(0);
        }

        return maxElement;
    }

    public T PeekMax()
    {
        T maxElement = this.heap[0];
        return maxElement;
    }

    public void Insert(T node)
    {
        this.heap.Add(node);
        this.HeapifyUp(this.Count - 1);
    }

    private void HeapifyDown(int parentIndex)
    {
        int leftChildIndex = parentIndex * 2 + 1;
        int rightChildIndex = parentIndex * 2 + 2;
        T parent = this.heap[parentIndex];
        int biggerElementIndex = parentIndex;

        if (leftChildIndex < this.Count && this.heap[leftChildIndex].CompareTo(parent) > 0)
        {
            biggerElementIndex = leftChildIndex;
        }

        if (rightChildIndex < this.Count && this.heap[rightChildIndex].CompareTo(this.heap[biggerElementIndex]) > 0)
        {
            biggerElementIndex = rightChildIndex;
        }

        if (biggerElementIndex != parentIndex)
        {
            this.heap[parentIndex] = this.heap[biggerElementIndex];
            this.heap[biggerElementIndex] = parent;

            this.HeapifyDown(biggerElementIndex);
        }
    }

    private void HeapifyUp(int childIndex)
    {
        while (childIndex > 0)
        {
            int parentIndex = (childIndex - 1) / 2;
            T parent = this.heap[parentIndex];
            T child = this.heap[childIndex];
            if (parent.CompareTo(child) >= 0)
            {
                break;
            }

            this.heap[parentIndex] = child;
            this.heap[childIndex] = parent;
            childIndex = parentIndex;
        }
    }
}
