using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:38 -  12:35 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            int height = 2 * n;
            int width = height + 1;
            int radius = n/2*(n/2);
            int center = n + n/2;
            int counter = 3;

            for (int i = 0; i < height; i++)
            {
                if (i == 0)
                {
                    Console.Write(new string('-', (width - n - 2) / 2));
                    Console.Write(new string('*', n + 2));
                    Console.Write(new string('-', (width - n - 2) / 2));
                }
                else if (i <= n)
                {
                    Console.Write(new string('-', (width - n - 2) / 2));
                    Console.Write("*");
                    Console.Write(new string('-', n));
                    Console.Write("*");
                    Console.Write(new string('-', (width - n - 2) / 2));
                }
                else if (i <= center)
                {
                    Console.Write(new string('-', (width - (n + 1 - counter) - counter * 2) / 2));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('-', n + 1 - counter));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('-', (width - (n + 1 - counter) - counter * 2) / 2));
                    counter += 2;
                }
                else
                {
                    if (counter == n + 2)
                    {
                        counter = n - 2;
                    }
                    Console.Write(new string('-', (width - (n + 1 - counter) - counter * 2) / 2));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('-', n + 1 - counter));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('-', (width - (n + 1 - counter) - counter * 2) / 2));
                    counter -= 2;
                }
                Console.WriteLine();
            }


        }
    }
}
//int horizontal = 1 + 2*((int)Math.Sqrt(radius - (center -i)*(center-i) ));
//Console.WriteLine(horizontal);
//Console.Write(new string('*', 1 + 2*((int)Math.Sqrt(radius - (center -i)*(center-i) ))));