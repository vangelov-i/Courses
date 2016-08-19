using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 19:13 - 19:23  // 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());
            int body = 2 * n;
            int counter = 1;
            for (int i = 0; i < n + ((n - 1) / 2); i++)
            {

                if (i <= n / 2)
                {
                    Console.Write(new string('.', n - counter));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('.', n));
                    counter += 2;
                }
                else if (i < n)
                {
                    if (i == n / 2 + 1)
                    {
                        counter -= 4;
                    }
                    Console.Write(new string('.', n - counter));
                    Console.Write(new string('*', counter));
                    Console.Write(new string('.', n));
                    counter -= 2;
                }
                else
                {
                    Console.Write(new string('.', (2 * n - body) / 2));
                    Console.Write(new string('*', body));
                    Console.Write(new string('.', (2 * n - body) / 2));
                    body -= 2;
                }
                Console.WriteLine();

            }


        }
    }
}
