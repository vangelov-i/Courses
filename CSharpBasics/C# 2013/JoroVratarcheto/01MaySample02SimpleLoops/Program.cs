using System;
using System.Numerics;

//18:50 - 19:15

namespace _01MaySample02SimpleLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(t1);
                    return;
                case 2:
                    Console.WriteLine(t2);
                    return;
                case 3:
                    Console.WriteLine(t3);
                    return;
            }
            BigInteger tNext = 0;
            for (int i = 3; i < n; i++)
            {

                tNext = t1 + t2 + t3;

                t1 = t2;
                t2 = t3;
                t3 = tNext;
            }
            checked { }
            Console.WriteLine(tNext);
        }
    }
}
