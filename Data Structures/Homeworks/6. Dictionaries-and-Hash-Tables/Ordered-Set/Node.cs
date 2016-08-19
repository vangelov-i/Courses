using System;

public class Node<T>
{
    public Node(T value) //, Node<T> parent, Node<T> left, Node<T> right
    {
        this.Value = value;
        //this.Parent = parent;
        //this.Left = left;
        //this.Right = right;
    }

    public T Value { get; set; }

    public Node<T> Parent { get; set; }

    public Node<T> Left { get; set; }

    public Node<T> Right { get; set; }

    public override string ToString()
    {
        return this.Value.ToString();
    }
}