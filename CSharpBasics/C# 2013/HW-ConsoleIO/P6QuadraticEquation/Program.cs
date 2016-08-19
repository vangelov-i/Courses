using System;
using System.Text;

namespace P6QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("To calculate the roots of a*x^2 + b*x + c = 0 , please enter the needed coefficients (a,b,c)");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            double x2 = (b * -1 + Math.Sqrt(b*b - 4*a*c))/(2*a);
            double x1 = (b * -1 - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            if (x1 == x2)
            {
                Console.WriteLine("x1=x2={0}", x1);
            }
            else if(double.IsNaN(x1) && double.IsNaN(x2))
            {
                Console.WriteLine("No real roots!");
            }
            else
            {
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
            
        }
    }
}
