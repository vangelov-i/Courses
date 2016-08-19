using System;

//Write a program that reads a number n and a sequence of n 
//integers, sorts them and prints them. Examples:

class SortingNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(array);
        foreach (var num in array)
        {
            Console.WriteLine(num);
        }
    }
}
