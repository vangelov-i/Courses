using System;

namespace _12ZeroSubset
{
    class Program
    {
        static void Main()
        {
        //We are given 5 integer numbers. Write a program that finds
        //all subsets of these numbers whose sum is 0. Assume that
        //repeating the same subset several times is not a problem. Examples:
        start:
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int sum = a + b + c + d + e;

            if (sum != 0)
            {
                if (a + b == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, b);
                }
                if (a + c == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, c);
                }
                if (a + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, d);
                }
                if (a + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", a, e);
                }
                if (b + c == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, c);
                }
                if (b + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, d);
                }
                if (b + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", b, e);
                }
                if (c + d == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, d);
                }
                if (c + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", c, e);
                }
                if (d + e == 0)
                {
                    Console.WriteLine("{0} + {1} = 0", d, e);
                }
                if (a + b + c == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
                }
                if (a + b + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
                }
                if (a + b + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
                }
                if (b + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, d);
                }
                if (b + c + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, c, e);
                }
                if (b + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", b, d, e);
                }
                if (c + d + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} = 0", c, d, e);
                }
                if (a + b + c + d == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
                }
                if (a + b + c + e == 0)
                {
                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
                }
                else
                {
                    Console.WriteLine("no zero subset");
                }
            }
            else
            {
                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            }
            goto start;
        }
    }
}
