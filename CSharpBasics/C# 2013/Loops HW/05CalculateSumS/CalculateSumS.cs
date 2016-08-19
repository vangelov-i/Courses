using System;

namespace _05CalculateSumS
{
    class CalculateSumS
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double xPow = 0;
            double s = 1;
            double factorial = 1;

            for (int i = 1; i <= n ; i++)
            {
                xPow = (int)Math.Pow(x, i);
                factorial *= i;
                s += (factorial / xPow);
            }
            Console.WriteLine("{0:F5}",s);
        }
    }
}
