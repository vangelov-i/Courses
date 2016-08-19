using System;

namespace _12AprilMorningHouse
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int halfN = n / 2;
            int counter = 1;
            Console.Write(new string('.', halfN));
            Console.Write("*");
            Console.WriteLine(new string('.', halfN));
            for (int i = 1; i < n; i++)
            {
                int halfNMinusI = halfN - i;
                if (i < halfN)
                {
                    Console.Write(new string('.', halfNMinusI));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', halfNMinusI));
                    counter += 2;
                }
                else if (i == halfN)
                {
                    Console.Write(new string('*', n));
                }
                else if (i > halfN && i != n - 1)
                {
                    Console.Write(new string('.', n / 4));
                    Console.Write("*");
                    Console.Write(new string('.', (n - 2 * (n / 4) - 2)));
                    Console.Write("*");
                    Console.Write(new string('.', n / 4));
                }
                else
                {
                    Console.Write(new string('.', n / 4));
                    Console.Write(new string('*', (n - 2 * (n / 4))));
                    Console.Write(new string('.', n / 4));
                }
                Console.WriteLine();
            }
        }
    }
}
