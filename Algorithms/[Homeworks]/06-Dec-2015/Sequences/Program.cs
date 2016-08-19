using System;
using System.Collections.Generic;
using System.Text;
// 12 min - 100

class Program
{
    private static List<int> subset;
    private static StringBuilder output;
     
    static void Main()
    {
        subset = new List<int>();
        output = new StringBuilder();
        int s = int.Parse(Console.ReadLine());

        FindSubsets(0, s);
        Console.Write(output);
    }

    private static void FindSubsets(int currentSum, int targetSum)
    {
        if (currentSum > targetSum)
        { 
            return;
        }

        output.AppendLine(string.Join(" ", subset));
        //Console.WriteLine(string.Join(" ", subset));

        for (int i = 1; i <= targetSum; i++)
        {
            subset.Add(i);
            int updatedSum = currentSum + i;
            FindSubsets(updatedSum, targetSum);
            subset.RemoveAt(subset.Count - 1);
        }
    }
}