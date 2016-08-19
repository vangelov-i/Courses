using System;

//Write a program to calculate the nth Catalan number 
//by given n (1 < n < 100). Examples:

//n	    Catalan(n)
//0	    1
//5	    42
//10	16796
//15	9694845

class CatalanNumbers
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double nX2 = n * 2;
        double nPlus1 = n + 1;
        double nFac = 1;
        double nX2Fac = 1;
        double nPlus1Fac = 1;

        for (int i = 1; i <= nX2; i++)
        {
            if (i <= n)
            {
                nFac *= i;
            }
            nX2Fac *= i;
            if (i <= n + 1)
            {
                nPlus1Fac *= i;
            }
        }
        Console.WriteLine("Cn = {0}", nX2Fac / (nPlus1Fac * nFac));
    }
}
