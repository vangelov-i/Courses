using System;

namespace _05.TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            if (a > b && a >c)
            {
                Console.WriteLine("Biggest number: " + a);
            }
            else if (b > a && b >c)
            {
                Console.WriteLine("Biggest number: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Biggest number: " + c);
            }
            else 
            {
                Console.WriteLine("The three numbers are equal.");
            }
        }
    }
}
