using System;
using System.Collections.Generic;

public class BinaryHeap<T> where T : IComparable<T>
{
    private List<T> heap;

    public BinaryHeap()
    {
        this.heap = new List<T>();
    }

    public BinaryHeap(T[] elements)
    {
        this.heap = new List<T>(elements);
        for (int i = this.heap.Count / 2; i >= 0; i--)
        {
            this.HeapifyDown(i);
        }
    }

    public int Count
    {
        get
        {
            return this.heap.Count;
        }
    }

    public T ExtractMax()
    {
        T max = this.heap[0];

        int lastElementIndex = this.Count - 1;
        this.heap[0] = this.heap[lastElementIndex];
        this.heap.RemoveAt(lastElementIndex);
        this.HeapifyDown(0);

        return max;
    }

    public T PeekMax()
    {
        return this.heap[0];
    }

    public void Insert(T node)
    {
        this.heap.Add(node);
        this.HeapifyUp(this.Count - 1);
    }

    private void HeapifyDown(int parentIndex)
    {
        int leftChilldIndex = 2 * parentIndex + 1;
        int rightChilldIndex = 2 * parentIndex + 2;
        int biggerChildIndex = this.GetBiggerChildIndex(leftChilldIndex, rightChilldIndex);

        bool biggerChildExists = biggerChildIndex >= 0 && this.heap[biggerChildIndex].CompareTo(this.heap[parentIndex]) == 1;
        while (biggerChildExists)
        {
            T old = this.heap[parentIndex];
            this.heap[parentIndex] = this.heap[biggerChildIndex];
            this.heap[biggerChildIndex] = old;

            parentIndex = biggerChildIndex;
            leftChilldIndex = 2 * parentIndex + 1;
            rightChilldIndex = 2 * parentIndex + 2;

            biggerChildIndex = this.GetBiggerChildIndex(leftChilldIndex, rightChilldIndex);
            biggerChildExists = biggerChildIndex >= 0 && this.heap[biggerChildIndex].CompareTo(this.heap[parentIndex]) == 1;
        }
    }

    private int GetBiggerChildIndex(int leftChilldIndex, int rightChilldIndex)
    {
        bool leftChildExists = leftChilldIndex < this.Count;
        bool rightChildExists = rightChilldIndex < this.Count;
        bool noChildren = !leftChildExists && !rightChildExists;
        if (noChildren)
        {
            return -1;
        }

        if (leftChildExists && rightChildExists)
        {
            int biggerChildIndex = this.heap[leftChilldIndex].CompareTo(this.heap[rightChilldIndex]) == 1 ? leftChilldIndex : rightChilldIndex;

            return biggerChildIndex;
        }

        if (leftChildExists)
        {
            return leftChilldIndex;
        }

        return rightChilldIndex;

    }

    private void HeapifyUp(int childIndex)
    {
        int parentIndex = (childIndex - 1) / 2;
        while (parentIndex >= 0 && this.heap[parentIndex].CompareTo(this.heap[childIndex]) == -1)
        {
            T old = this.heap[childIndex];
            this.heap[childIndex] = this.heap[parentIndex];
            this.heap[parentIndex] = old;

            childIndex = parentIndex;
            parentIndex = (childIndex - 1) / 2;
        }
    }
}
