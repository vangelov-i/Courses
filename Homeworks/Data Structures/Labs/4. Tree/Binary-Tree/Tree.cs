using System;
using System.Collections.Generic;
using System.Linq;

public class Tree<T>
{
    public Tree(T value, params Tree<T>[] children)
    {
        this.Value = value;
        this.Children = children.ToList();
    }

    public T Value { get; set; }

    public List<Tree<T>> Children { get; set; } 

    public void Print(int indent = 0)
    {
        Console.WriteLine("{0}{1}", new string(' ', 2 * indent), this.Value);
        foreach (var child in this.Children)
        {
            child.Print(indent + 1);
        }
    }

    public void Each(Action<T> action)
    {
        action(this.Value);
        foreach (var child in this.Children)
        {
            child.Each(action);
        }
    }
}
