using System;

//Write a program that enters 3 integers n, min and max (min ≤ max) 
//and prints n random numbers in the range [min...max]. Examples:

//n	    min	    max	    random numbers
//5	    0	    1	    1 0 0 1 1
//10	10	    15	    12 14 12 15 10 12 14 13 13 11

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max (where max > min): ");
        int max = int.Parse(Console.ReadLine());
        Random num = new Random();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(num.Next(min, max + 1));
        }
    }
}
