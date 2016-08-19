using System;
using System.Text;

namespace P4NumberComparer
{
    class P4NumberComparer
    {
        static void Main()
        {
            float a;
            float b;
            Console.Write("a = ");
            float.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            float.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("The greater number is: {0}", Math.Max(a,b));
        }
    }
}
