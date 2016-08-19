using System;

//Write an expression that checks if given positive integer number n (n ≤ 100)
//is prime (i.e. it is divisible without remainder only to itself and 1). Examples:
//n	    Prime?

//1	    false
//2	    true
//3	    true
//4	    false
//9	    false
//97	true
//51	false
//-3	false
//0	    false

namespace _08PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main() 
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (n <=1)
            {
                isPrime = false;
            }
            Console.WriteLine(isPrime);
        }
    }
}
