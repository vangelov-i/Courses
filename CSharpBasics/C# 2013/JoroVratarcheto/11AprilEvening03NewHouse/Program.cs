using System;

namespace _11AprilEvening03NewHouse
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + (n / 2) + 1; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('-', n / 2));
                    Console.Write("*");
                    Console.Write(new string('-', n / 2));
                }
                else if (i < n / 2)
                {
                    Console.Write(new string('-', (n / 2) - i));
                    Console.Write(new string('*', n - 2 * ((n / 2) - i)));
                    Console.Write(new string('-', (n / 2) - i));
                }
                else if (i == n / 2)
                {
                    Console.Write(new string('*', n));
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string('*', n - 2));
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
    }
}