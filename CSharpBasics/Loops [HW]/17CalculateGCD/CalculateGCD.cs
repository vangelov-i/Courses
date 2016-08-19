using System;

//Write a program that calculates the greatest common divisor (GCD)
//of given two integers a and b. Use the Euclidean algorithm (find 
//it in Internet). Examples:

//a	    b	    GCD(a, b)
//3	    2	    1
//60	40	    20
//5	    -15	    5

class CalculateGCD
{
    static void Main(string[] args)
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
