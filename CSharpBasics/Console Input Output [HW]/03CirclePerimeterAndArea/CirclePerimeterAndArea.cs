using System;

//Write a program that reads the radius r of a 
//circle and prints its perimeter and area formatted
//with 2 digits after the decimal point. Examples:

//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48


namespace _03CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double perimeter = 2 * Math.PI * r;
            double area = Math.PI * r * r;
            Console.WriteLine("Perimeter: {0:F2}", perimeter);
            Console.WriteLine("Area: {0:F2}", area);
        }
    }
}
