using System;

//Write a program that reads the coefficients a, b and c of a
//quadratic equation ax2 + bx + c = 0 and solves it (prints its 
//real roots). Examples:

//a	    b	    c	    roots
//2	    5	    -3	    x1=-3; x2=0.5
//-1	3	    0	    x1=3; x2=0
//-0.5	4	    -8	    x1=x2=4
//5	    2	    8	    no real roots

namespace _06QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double x1 = (-b - Math.Sqrt(b * b - (4 * a * c))) / (2 * a);
            double x2 = (-b + Math.Sqrt(b * b - (4 * a * c))) / (2*a);

            if (x1 == x2)
            {
                Console.WriteLine("x1=x2={0}", x1);
            }
            else if (double.IsNaN(x1) && double.IsNaN(x2))
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                Console.WriteLine("x1={0}; x2={1}", x1, x2);
            }
        }
    }
}
