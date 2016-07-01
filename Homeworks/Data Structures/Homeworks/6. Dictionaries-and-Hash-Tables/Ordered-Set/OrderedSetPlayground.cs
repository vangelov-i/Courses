using System;

class OrderedSetPlayground
{
    static void Main()
    {
        var mySet = new OrderedSet<int>();
        mySet.Add(17);
        mySet.Add(9);
        mySet.Add(12);
        mySet.Add(19);
        mySet.Add(51);
        mySet.Add(7);
        mySet.Add(34);
        mySet.Add(16);
        mySet.Add(11);
        mySet.Add(22);
        mySet.Add(6);
        mySet.Add(25);

        int i = 1;
        Console.WriteLine(mySet.Count);
        foreach (int entry in mySet)
        {
            Console.WriteLine(i++ + " -> " + entry);
        }
    }
}