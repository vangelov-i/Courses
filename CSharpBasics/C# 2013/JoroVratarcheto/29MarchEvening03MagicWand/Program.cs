using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:00 - 11:35  -> 3 zero testa rabotqt => 0/100 !!! :DDDD + 5 min -> 100!
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            int width = n * 3 + 2;
            int counter = 1;
            int counter2 = 0;
            int top = n - ((n-1) / 2) + 1;
            int body = top + n + 1;
            int stick = body + n + 1;
            for (int i = 0; i < stick; i++)
            {

                if (i == 0)
                {
                    Console.Write(new string('.', (width - 1) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 1) / 2));
                }
                else if (i < top)
                {
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    counter += 2;
                }
                else if (i == top)
                {
                    Console.Write(new string('*', n));
                    Console.Write(new string('.', n + 2));
                    Console.Write(new string('*', n));
                }
                else if (i < body - (n + 1) / 2)
                {
                    if (i == top + 1)
                    {
                        counter = width - 4;
                    }
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter));
                    Console.Write("*");
                    Console.Write(new string('.', (width - 2 - counter) / 2));
                    counter -= 2;
                }
                else if (i < body - 1)
                {
                    Console.Write(new string('.', n - 2 - n / 2 - counter2));
                    Console.Write("*");
                    Console.Write(new string('.', n / 2));
                    Console.Write("*");
                    Console.Write(new string('.', counter2));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', counter2));
                    Console.Write("*");
                    Console.Write(new string('.', n / 2));
                    Console.Write("*");
                    Console.Write(new string('.', n - 2 - n / 2 - counter2));
                    counter2++;
                }
                else if (i < body)
                {
                    Console.Write(new string('*', n - counter2));
                    Console.Write(new string('.', counter2));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', counter2));
                    Console.Write(new string('*', n - counter2));
                }
                else if (i != stick - 1)
                {
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                    Console.Write("*");
                    Console.Write(new string('.', n));
                }
                else
                {
                    Console.Write(new string('.', n));
                    Console.Write(new string('*', n + 2));
                    Console.Write(new string('.', n));
                }
                Console.WriteLine();

            }

        }
    }
}