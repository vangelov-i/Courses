using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:45 - 13:25 // 
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int height = n * 3 - n / 2;
            int counter = 1;
            int dotsCount = 1;
            int bottomDots = (width - n - 2) / 2;
            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('.', (width - 1)/2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 1) / 2));
                }
                else if (counter <= n+2)
                {
                    Console.Write(new string('.', (width - 2 - counter)/2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    counter += 2;
                }
                else if (i <= n)
                {
                    counter += 2;
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    counter += 2;
                }
                else if (i == n + 1)
                {
                    Console.Write("*");
                    Console.Write(new string('.', (width - 4 - n) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 4 - n) / 2));
                    Console.Write("*");
                }
                else if (i <= n + n/2)
                {
                    
                    Console.Write("*");
                    Console.Write(new string('.', (width - 6 - n - dotsCount*2) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', dotsCount));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', dotsCount));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 6 - n - dotsCount * 2) / 2));
                    Console.Write("*");
                    dotsCount += 2;
                }
                else if (i == height-1)
                {
                    Console.Write(new string('*', width));
                }
                else
                {
                    Console.Write(new string('.', bottomDots));
                    Console.Write("*");
                    Console.Write(new string('.', width - bottomDots*2 - 2));
                    Console.Write("*");
                    Console.Write(new string('.', bottomDots));
                    bottomDots--;
                }
                Console.WriteLine();
            }


        }
    }
}
