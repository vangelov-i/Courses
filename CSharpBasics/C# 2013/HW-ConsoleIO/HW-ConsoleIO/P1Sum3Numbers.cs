using System;
using System.Text;


namespace HW_ConsoleIO
{
    class P1Sum3Numbers
    {
        static void Main()
        {
            double a;
            double b;
            double c;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b + c = {0}", a+b+c);

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b + c = {0}", a + b + c);

            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("a + b + c = {0}", a + b + c);
        }
    }
}
