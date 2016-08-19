using System;

public class ArrayStack<T>
{
    private const int DefaultCapacity = 16;

    private T[] elements;

    public ArrayStack(int capacity = DefaultCapacity)
    {
        this.elements = new T[capacity];
    }

    public int Count { get; private set; }

    public void Push(T element)
    {
        if (this.Count == this.elements.Length)
        {
            this.Resize();
        }

        this.elements[this.Count] = element;
        this.Count++;
    }

    public T Pop()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        this.Count--;
        T element = this.elements[this.Count];
        this.elements[this.Count] = default(T);

        return element;
    }

    public T Peek()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return this.elements[this.Count - 1];
    }

    private void Resize()
    {
        var newElements = new T[this.Count * 2];
        for (int index = 0; index < this.Count; index++)
        {
            newElements[index] = this.elements[index];
        }

        this.elements = newElements;
    }

    public T[] ToArray()
    {
        var result = new T[this.Count];
        for (int index = this.Count - 1; index >= 0; index--)
        {
            result[this.Count - 1 - index] = this.elements[index];
        }

        return result;
    }
 }