using System;

public class CircularQueue<T>
{
    private const int DefaultCapacity = 16;

    private T[] array;

    private int head;
    private int tail;

    public int Count { get; private set; }

    public CircularQueue(int capacity = DefaultCapacity)
    {
        this.array = new T[capacity];
    }

    public void Enqueue(T element)
    {
        if (this.Count == this.array.Length)
        {
            this.ResizeArray();
        }

        this.array[this.tail % this.array.Length] = element;
        this.tail= (this.tail + 1) % this.array.Length;
        this.Count++;
    }

    private void ResizeArray()
    {
        var newArr = new T[this.Count * 2];
        for (int i = 0; i < this.Count; i++)
        {
            newArr[i] = this.array[(i + this.head) % this.Count];
        }

        this.head = 0;
        this.tail = this.array.Length;
        this.array = newArr;
    }

    public T Dequeue()
    {
        if (this.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        var item = this.array[this.head];
        this.array[this.head] = default(T);
        this.head = (this.head + 1) % this.array.Length;
        this.Count--;

        return item;
    }

    public T[] ToArray()
    {
        var result = new T[this.Count];
        for (int index = 0; index < this.Count; index++)
        {
            result[index] = this.array[(this.head + index) % this.array.Length];
        }

        return result;
    }
}


class Example
{
    static void Main()
    {
        var queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        var first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);
        queue.Enqueue(-10);

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

    }
}
