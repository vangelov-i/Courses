using System;

namespace _17CalculateGCD
{
    class CalculateGCD
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine()); ;
            int gcd = 0;
            if (Math.Abs(a) < Math.Abs(b))
            {
                gcd = a;
            }
            else
            {
                gcd = b;
            }
            int reminderA = 0;
            int reminderB = 0;
            bool gcdIsFound = false;
            while (!gcdIsFound)
            {
                reminderA = a % gcd;
                reminderB = b % gcd;
                if (reminderA == 0 && reminderB == 0)
                {
                    gcdIsFound = true;
                    break;
                }
                gcd--;
            }
            Console.WriteLine(Math.Abs(gcd));
        }
    }
}
