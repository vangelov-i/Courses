using System;

// 19:20 - 19:30 

namespace _01MaySample03SandGlass
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
                    Console.Write(new string('*', n));
                }
                else if (i <= n/2)
                {
                    Console.Write(new string('.', i));
                    Console.Write(new string('*', n - 2 * i));
                    Console.Write(new string('.', i));
                }
                else
                {
                    Console.Write(new string('.', (n-(2*i-n+2))/2));
                    Console.Write(new string('*', 2 * i - n + 2));
                    Console.Write(new string('.', (n - (2 * i - n + 2)) / 2));
                }
                Console.WriteLine();
            }
        }
    }
}
