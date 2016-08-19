using System;

namespace _10AprilMorning03Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oneGlass = 2 * n;
            int sreda = n;
            int vatre = 2 * n - 2;

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.Write(new string('*', oneGlass));
                    Console.Write(new string(' ', sreda));
                    Console.Write(new string('*', oneGlass));
                }

                else if (i == n/2)
                {
                                        Console.Write("*");
                    Console.Write(new string('/', vatre));
                    Console.Write("*");
                    Console.Write(new string('|', sreda));
                    Console.Write("*");
                    Console.Write(new string('/', vatre));
                    Console.Write("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', vatre));
                    Console.Write("*");
                    Console.Write(new string(' ', sreda));
                    Console.Write("*");
                    Console.Write(new string('/', vatre));
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
