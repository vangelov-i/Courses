using System;
using System.Collections.Generic;

using System.Collections;

class ReversedList<T> : IEnumerable<T>
{
    private T[] array;

    public ReversedList(int length = 16)
    {
        this.array = new T[length];
    }

    public void Add(T item)
    {
        if (this.Count == this.array.Length)
        {
            this.ResizeArray();
        }
        this.array[this.Count++] = item;
    }

    public int Count { get; private set; }

    public int Capacity => this.array.Length;

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Index is outside the boundries of the list.");
            }

            index = this.Count - 1 - index;
            return this.array[index];
        }

        set
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException("Index is outside the boundries of the list.");
            }

            index = this.Count - 1 - index;
            this.array[index] = value;
        }
    }

    public void Remove(int index)
    {
        if (index < 0 || index >= this.Count)
        {
            throw new IndexOutOfRangeException("Index is outside the boundries of the list.");
        }

        index = this.Count - 1 - index;
        Array.Copy(this.array, index + 1, this.array, index, this.Count - index);
        this.Count--;

        this.array[this.Count] = default(T);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int index = this.Count - 1; index >= 0; index--)
        {
            yield return this.array[index];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    private void ResizeArray()
    {
        var newArr = new T[this.Count * 2];
        for (int index = 0; index < this.Count; index++)
        {
            newArr[index] = this.array[index];
        }

        this.array = newArr;
    }
}