using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12AprilMorningHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dot = ".";
            string star = "*";
            int halfN = n / 2;
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                int halfNMinusI = halfN - i;
                if (i < halfN)
                {
                    Console.Write(new string('.', halfNMinusI));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('.', counter));
                    if (i != 0)
                    {
                        Console.Write(new string('*', 1));

                    }
                    Console.Write(new string('.', halfNMinusI));
                }
                else if (i == halfN)
                {
                    Console.Write(new string('*', n));
                }
                else if (i > halfN && i != n - 1)
                {
                    Console.Write(new string('.', n / 4));
                    Console.Write("*");
                    Console.Write(new string('.', (n - 2 * (n / 4) - 2))); /// magic number
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
                if (i == 0)
                {
                    counter++;
                }
                else
                {
                    counter += 2;
                }

            }
        }
    }
}
