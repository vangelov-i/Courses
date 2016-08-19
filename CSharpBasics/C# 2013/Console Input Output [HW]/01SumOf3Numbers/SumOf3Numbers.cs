using System;

//Write a program that reads 3 real numbers from the console and prints their sum. Examples:
//a	b	c	    sum
//3	4	11  	18
//-2	0	3   	1
//5.5	4.5	20.1	30.1


namespace _01SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine(a + b + c);
        }
    }
}
