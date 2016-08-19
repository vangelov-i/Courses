using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:08 - 16:15 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            char symbol = s[0];
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                if (i < n / 2)
                {
                    Console.Write(new string('-', (n - counter) / 2));
                    Console.Write(new string(symbol, counter));
                    Console.Write(new string('-', (n - counter) / 2));
                    counter += 2;
                }
                else
                {
                    Console.Write(new string('-', (n - counter) / 2));
                    Console.Write(new string(symbol, counter));
                    Console.Write(new string('-', (n - counter) / 2));
                    counter -= 2;
                }
                Console.WriteLine();
            }


        }
    }
}