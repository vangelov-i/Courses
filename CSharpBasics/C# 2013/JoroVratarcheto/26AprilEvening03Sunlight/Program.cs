using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:04 - 11: 18 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());
            int height = 3 * n;
            int counter = 1;
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    Console.Write(new string('.', (height - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (height - 1) / 2));
                }
                else if (i < n)
                {
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (height - 2 * counter - 3) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (height - 2 * counter - 3) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    counter++;
                }
                else if (i < height / 2)
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', n));
                }
                else if (i == height / 2)
                {
                    Console.Write(new string('*', height));
                    counter--;
                }
                else if (i < height - n)
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', n));
                }
                else
                {
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (height - 2 * counter - 3) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (height - 2 * counter - 3) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    counter--;
                }

                Console.WriteLine();
            }




        }
    }
}