using System;
using System.Text;

namespace ConsoleInput_Output_Exercise
{
    class P1ConvertingNumbers
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Това е кирилица: :)");
            int a;
            double b;
            double c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, -10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);


            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, -10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, -10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);

        }
    }
}
