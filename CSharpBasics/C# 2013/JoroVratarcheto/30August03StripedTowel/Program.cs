using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 13:49 - 13:57 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            int height = n + n / 2;
            string part = "#..";
            for (int i = 0; i < height * n; i++)
            {
                Console.Write(part[i % 3]);
                if ((i+1) % n == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}