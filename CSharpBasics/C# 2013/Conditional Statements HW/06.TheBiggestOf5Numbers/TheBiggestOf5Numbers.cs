using System;

namespace _06.TheBiggestOf5Numbers
{
    class TheBiggestOf5Numbers
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            float e = float.Parse(Console.ReadLine());

            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine("biggest number: " + a);
            }
            else if (b >= a && b >= c && b >= d && b >= e)
            {
                Console.WriteLine("biggest number: " + b);
            }
            else if (c >= a && c >= b && c >= d && c >= e)
            {
                Console.WriteLine("biggest number: " + c);
            }
            else if (d >= a && d >= b && d >= c && d >= e)
            {
                Console.WriteLine("biggest number: " + d);
            }
            else
            {
                Console.WriteLine("biggest number: " + e);
            }
        }
    }
}
