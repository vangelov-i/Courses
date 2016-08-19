using System;

//14:10 - 14:50 // 40 min

namespace _08November03RockLq
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oneLine = 3 * n;
            int secondHalfCounter = n-1;
            int firstHalfCounter = n-2;
            int firstHalfCounter2 = n - 4;
            int preMiddleCounter = 1;
            for (int i = 0; i < 2*n; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', n));
                }
                else if (i <= n/2)
                {
                    Console.Write(new string('.', firstHalfCounter));
                    Console.Write("*");
                    Console.Write(new string('.', oneLine - 2 - 2 * firstHalfCounter));
                    Console.Write("*");
                    Console.Write(new string('.', firstHalfCounter));
                    firstHalfCounter -= 2;
                }
                else if (i == n/2 +1)
                {
                    Console.Write("*");
                    Console.Write(new string('.', n-2));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', n - 2));
                    Console.Write("*");
                }
                else if (i > n / 2 && i <= n - 1)
                {
                    Console.Write("*");
                    Console.Write(new string('.', firstHalfCounter2));
                    Console.Write("*");
                    Console.Write(new string('.', preMiddleCounter));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', preMiddleCounter));
                    Console.Write("*");
                    Console.Write(new string('.', firstHalfCounter2));
                    Console.Write("*");
                    preMiddleCounter += 2;
                    firstHalfCounter2 -= 2;
                }
                else if (i > n -1 && i != 2*n-1)
                {
                    Console.Write(new string('.',secondHalfCounter ));
                    Console.Write("*");
                    Console.Write(new string('.', oneLine - 2 - 2*secondHalfCounter));
                    Console.Write("*");
                    Console.Write(new string('.', secondHalfCounter));
                    secondHalfCounter--;
                }
                else if (i == 2*n-1)
                {
                    Console.WriteLine(new string('*', oneLine));
                }
                Console.WriteLine();
            }
        }
    }
}
