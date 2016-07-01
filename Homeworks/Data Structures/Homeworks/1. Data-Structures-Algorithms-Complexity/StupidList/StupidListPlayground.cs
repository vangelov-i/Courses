using System;
using System.Collections.Generic;

class StupidListPlayground
{
    public static void Main()
    {
        var smartList = new List<int>();
        var start = DateTime.Now;
        for (int i = 0; i < 200000; i++)
        {
            smartList.Add(i);
        }
        var execution = DateTime.Now - start;
        Console.WriteLine(execution);


        var stupidList = new StupidList<int>();
        start = DateTime.Now;
        for (int i = 0; i < 50000; i++)
        {
            stupidList.Add(i);
        }
        execution = DateTime.Now - start;
        Console.WriteLine(execution);

        start = DateTime.Now;
        for (int i = 0; i < 50000; i++)
        {
            stupidList.Remove(stupidList.Length / 2);
        }
        execution = DateTime.Now - start;
        Console.WriteLine(execution);

    }
}