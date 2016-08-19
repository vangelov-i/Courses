using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 18:40 - 19:10
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n - 1;
        int height = 2 * n + 2;
        int heighRoof = n;
        int baseHouse = n + 2;
        int windowHeight = n / 2;
        int windowWidht = n - 3;
        int counterRoof = 1;

        for (int i = 0; i < height; i++)
        {
            if (i == 0)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write("*");
                Console.Write(new string('.', n - 1 - i));
            }
            else if (i < n)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write("*");
                Console.Write(new string('.', counterRoof));
                Console.Write("*");
                Console.Write(new string('.', n - 1 - i));
                counterRoof += 2;
            }
            else if (i == n)
            {
                Console.Write(new string('*', width));
            }
            else if (i <= n + n / 4 || i >= height - 1 - n / 4 && i != height - 1)
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
                Console.Write(new string('.', (width - 2 - windowWidht) / 2));
                Console.Write(new string('*', windowWidht));
                Console.Write(new string('.', (width - 2 - windowWidht) / 2));
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}