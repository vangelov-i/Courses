using System;

class Program
{
    static void Main()
    {
        var myList = new SinglyLinkedList<int>();
        myList.Add(1);
        myList.Add(2);
        myList.Add(3);
        myList.Add(2);
        myList.Add(1);

        Console.WriteLine(string.Join(" ", myList));
        Console.WriteLine(myList.FirstIndexOf(2));
        myList.Remove(4);
        Console.WriteLine(string.Join(" ", myList));
        Console.WriteLine(myList.Count);

    }
}