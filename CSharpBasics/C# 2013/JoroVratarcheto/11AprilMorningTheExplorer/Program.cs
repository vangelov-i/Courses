using System;

namespace _11AprilMorningTheExplorer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n-1)
                {
                    Console.Write(new string('-', n / 2));
                    Console.Write("*");
                    Console.Write(new string('-', n / 2));

                }
                else if (i < n / 2)
                {
                    Console.Write(new string('-', n / 2 - i));
                    Console.Write("*");
                    Console.Write(new string('-', n - (n / 2 - i) * 2 - 2));
                    Console.Write("*");
                    Console.Write(new string('-', n / 2 - i));
                }
                else if (i == n/2)
                {
                    Console.Write("*");
                    Console.Write(new string('-', n - 2));
                    Console.Write("*");
                }
                else if (i > n/2 && i != n-1)
                {
                    Console.Write(new string('-', i - n/2));
                    Console.Write("*");
                    Console.Write(new string('-', n - 2 - 2*(i - n / 2)));
                    Console.Write("*");
                    Console.Write(new string('-', i - n / 2));
                }
                Console.WriteLine();
            }
        }
    }
}
