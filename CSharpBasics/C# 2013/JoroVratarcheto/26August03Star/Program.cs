using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:20 - 17:50 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int n = int.Parse(Console.ReadLine());

            int width = 2 * n + 1;
            int height = n * 2 - (n / 2 - 1);
            int topAndMiddle = n / 2;
            int bottomLegs = n / 2 + 1;
            int counter = 1;
            for (int i = 0; i < height; i++)
            {

                if (i == 0)
                {
                    Console.Write(new string('.', (width - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 1) / 2));
                }
                else if (i < n / 2)
                {
                    Console.Write(new string('.', (width - counter - 2) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (width - counter - 2) / 2));
                    counter += 2;
                }
                else if (i == n/2)
                {
                    Console.Write(new string('*', (width - counter)/2));
                    Console.Write(new string('.', (width - (width -counter))));
                    Console.Write(new string('*', (width - counter) / 2));
                }
                else if (i < n)
                {
                    Console.Write(new string('.', i - n / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 2 - (i - n / 2) * 2)));
                    Console.Write("*");
                    Console.Write(new string('.', i - n / 2));
                }
                else if (i == n)
                {
                    Console.Write(new string('.', i - n / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 3 - (i - n / 2) * 2) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 3 - (i - n / 2) * 2) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', i - n / 2));
                    counter = 1;
                }
                else if (i == height - 1)
                {
                    Console.Write(new string('*', (width - counter) / 2));
                    Console.Write(new string('.', counter));
                    Console.Write(new string('*', (width - counter) / 2));
                }
                else
                {
                    Console.Write(new string('.', (width - counter - 4 - (((n-1)/2)*2)) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (n-1)/2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (n - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - counter - 4 - (((n - 1) / 2) * 2)) / 2));
                    counter += 2;
                }
                Console.WriteLine();

            }


        }
    }
}