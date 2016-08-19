using System;

//Write a program that reads from the console a positive integer number 
//n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two 
//nested loops. Examples:

//n	    matrix
//2	    1 2
//      2 3

//n 	matrix
//3 	1 2 3
//      2 3 4
//      3 4 5

//n	    matrix
//4	    1 2 3 4
//      2 3 4 5
//      3 4 5 6
//      4 5 6 7


class NatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            for (int j = 1; j < n; j++)
            {
                Console.Write("  {0}", i + j);
            }
            Console.WriteLine();
        }
    }
}
