using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 13:23 - 13:31
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            int width = n * 3;
            int counterDots = n / 2;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n-1)
                {
                    Console.Write(new string('.', counterDots));
                    Console.Write(new string('&', n - counterDots));
                    Console.Write(new string('.', n));
                    Console.Write(new string('&', n - counterDots));
                    Console.Write(new string('.', counterDots));
                    counterDots--;
                }
                else if (i < n/2)
                {
                    Console.Write(new string('.', counterDots));
                    Console.Write("&");
                    Console.Write(new string('*', n - counterDots - 2));
                    Console.Write("&");
                    Console.Write(new string('.', n));
                    Console.Write("&");
                    Console.Write(new string('*', n - counterDots - 2));
                    Console.Write("&");
                    Console.Write(new string('.', counterDots));
                    counterDots--;
                }
                else if (i == n/2)
                {
                    counterDots++;
                    Console.Write("&");
                    Console.Write(new string('*', n - 2));
                    Console.Write("&");
                    Console.Write(new string('=', n));
                    Console.Write("&");
                    Console.Write(new string('*', n - 2));
                    Console.Write("&");
                }
                else
                {
                    Console.Write(new string('.', counterDots));
                    Console.Write("&");
                    Console.Write(new string('*', n - counterDots - 2));
                    Console.Write("&");
                    Console.Write(new string('.', n));
                    Console.Write("&");
                    Console.Write(new string('*', n - counterDots - 2));
                    Console.Write("&");
                    Console.Write(new string('.', counterDots));
                    counterDots++;
                }
                Console.WriteLine();
            }



        }
    }
}