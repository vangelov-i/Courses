using System;

// 22:00 - 23:00

namespace _14AprilMorning03WineGlass
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // do polovinata
            for (int i = 0; i < n; i++)
            {
                if (n < 12)
                {
                    if (i == 0)
                    {
                        Console.Write(new string('.', i));
                        Console.Write("\\");
                        Console.Write(new string('*', n - 2));
                        Console.Write("/");
                        Console.Write(new string('.', i));
                    }
                    else if (i < n / 2)
                    {
                        Console.Write(new string('.', i));
                        Console.Write("\\");
                        Console.Write(new string('*', n - 2 - i * 2));
                        Console.Write("/");
                        Console.Write(new string('.', i));
                    }
                    else if (i >= n / 2 && i < n - 1)
                    {
                        Console.Write(new string('.', (n / 2 - 1)));
                        Console.Write("||");
                        Console.Write(new string('.', (n / 2 - 1)));
                    }
                    else
                    {
                        Console.Write(new string('-', n));
                    }
                    Console.WriteLine();
                }
                else
                {
                    if (i == 0)
                    {
                        Console.Write(new string('.', i));
                        Console.Write("\\");
                        Console.Write(new string('*', n - 2));
                        Console.Write("/");
                        Console.Write(new string('.', i));
                    }
                    else if (i < n / 2)
                    {
                        Console.Write(new string('.', i));
                        Console.Write("\\");
                        Console.Write(new string('*', n - 2 - i * 2));
                        Console.Write("/");
                        Console.Write(new string('.', i));
                    }
                    else if (i >= n / 2 && i < n-2)
                    {
                        Console.Write(new string('.', (n / 2 - 1)));
                        Console.Write("||");
                        Console.Write(new string('.', (n / 2 - 1)));
                    }
                    else
                    {
                        Console.Write(new string('-', n));
                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
