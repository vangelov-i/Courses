using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 20:52 - 21:02 -> 100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());

            int width = n * 2;
            int garlo = n + 1;
            int height = n * 3 + 1;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string(' ', (width - garlo) / 2));
                    Console.Write(new string('*', garlo));
                    Console.Write(new string(' ', (width - garlo) / 2));
                }
                else if (i <= n / 2 + 1)
                {
                    Console.Write(new string(' ', (width - garlo) / 2));
                    Console.Write("*");
                    Console.Write(new string(' ', garlo - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', (width - garlo) / 2));
                }
                else if (i < n)
                {
                    garlo += 2;
                    Console.Write(new string(' ', (width - garlo) / 2));
                    Console.Write("*");
                    Console.Write(new string(' ', garlo - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', (width - garlo) / 2));
                }
                else if (i < n * 2)
                {
                    Console.Write("*");
                    Console.Write(new string('.', width - 2));
                    Console.Write("*");
                }
                else if (i == height - 1)
                {
                    Console.Write(new string('*', width));
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('@', width - 2));
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}