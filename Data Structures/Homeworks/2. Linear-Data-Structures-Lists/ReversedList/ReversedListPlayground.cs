using System;

class ReversedListPlayground
{
    static void Main()
    {
        var testList = new ReversedList<int>();
        testList.Add(1);
        testList.Add(2);
        testList.Add(3);
        testList.Add(4);
        testList.Add(5);
        testList.Add(6);
        testList.Add(7);
        testList.Add(8);
        testList.Add(9);
        testList.Add(10);
        testList.Add(11);
        testList.Add(12);
        testList.Add(13);
        testList.Add(14);
        testList.Add(15);
        testList.Add(16);
        testList.Add(17);
        Console.WriteLine(testList.Capacity);
        testList.Remove(10);
        Console.WriteLine(string.Join(" ", testList));
        Console.WriteLine(testList[0]);
    }
}