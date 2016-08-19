using System;

//Write a program that, for a given two integer numbers n and x, 
//calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn. Use only 
//one loop. Print the result with 5 digits after the decimal point.

//n	    x	S
//3	    2	2.75000
//4	    3	2.07407
//5	    -4	0.75781

class CalculateSumS
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double xPow = 0;
        double s = 1;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            xPow = (int)Math.Pow(x, i);
            factorial *= i;
            s += (factorial / xPow);
        }
        Console.WriteLine("{0:F5}", s);
    }
}
