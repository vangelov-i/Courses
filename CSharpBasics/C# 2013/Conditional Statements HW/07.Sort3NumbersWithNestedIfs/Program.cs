using System;

namespace _07.Sort3NumbersWithNestedIfs
{
    class Program
    {
        static void Main()
        {
            start:
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.Write("{0} ", a);
                if (b >= c)
                {
                    Console.WriteLine("{0} {1}", b, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}", c, b);
                }
            }
            else if (b >= a && b >= c)
            {
                Console.Write("{0} ", b);
                if (a >= c)
                {
                    Console.WriteLine("{0} {1}", a, c);
                }
                else
                {
                    Console.WriteLine("{0} {1}",c, a);
                }
            }
            else
            {
                Console.Write("{0} ", c);
                if (a >= b)
                {
                    Console.WriteLine("{0} {1}", a, b);
                }
                else
                {
                    Console.WriteLine("{0} {1}",b,a);
                }
            }
            goto start;
        }
    }
}
