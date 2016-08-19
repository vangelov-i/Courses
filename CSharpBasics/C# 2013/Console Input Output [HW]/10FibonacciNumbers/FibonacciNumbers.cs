using System;

//Write a program that reads a number n and prints on the console
//the first n members of the Fibonacci sequence (at a single line,
//separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note that you may need to learn how to use loops. Examples:

//n	    comments
//1	    0
//3	    0 1 1
//10	0 1 1 2 3 5 8 13 21 34


namespace _10FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 1;
            int b = 0;
            int c = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",c);
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
