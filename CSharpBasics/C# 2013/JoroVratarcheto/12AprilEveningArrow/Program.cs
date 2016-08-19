using System;

namespace _12AprilEveningArrow
{
    class Program
    {
        static void Main(string[] args)
        {
            // cikal n*2 -1 (height and widht)
            // 1st half vatrei < n -> . * (n*2-1) - 2 - (n/2)  ; # ; . * n ; # ;. * n/2
            // i == n -> # * n/2 + 1 ; . * n , # * n/2+1
            // i > n -> . * n-i ; # ; . * 2*n - 2 - (n-i)
            // i == n*2-1 -> . * n-1 ; # ; .*n-1
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', n / 2));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n / 2));

            for (int i = 1; i < n*2 - 1 ; i++)
            {
                if (i < n-1)
                {
                    Console.Write(new string('.', n/2));
                    Console.Write("#");
                    Console.Write(new string('.', (n * 2) - 1 - 2 - 2*(n / 2)));
                    Console.Write("#");
                    Console.Write(new string('.', n/2));
                }
                else if (i == n-1)
                {
                    Console.Write(new string('#', n/2 +1));
                    Console.Write(new string('.', (n * 2) - 1 - 2 - 2*(n / 2)));
                    Console.Write(new string('#', n/2 +1));
                }
                else if (i > n-1 && i != n*2 - 2)
                {
                    Console.Write(new string('.', i-n + 1));
                    Console.Write("#");
                    Console.Write(new string('.', (2*n)-3 - 2*(i-n+1)));
                    Console.Write("#");
                    Console.Write(new string('.', i-n + 1));
                }
                else
                {
                    Console.Write(new string('.', n-1));
                    Console.Write("#");
                    Console.Write(new string('.', n-1));
                }
                Console.WriteLine();
            }
        }
    }
}
