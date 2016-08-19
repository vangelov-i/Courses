using System;

//Write a program that finds the biggest of three numbers. 
//Examples:

//a	        b	    c	    biggest
//5	        2	    2	    5
//-2	    -2	    1	    1
//-2	    4	    3	    4
//0	        -2.5	5	    5
//-0.1	    -0.5	-1.1	-0.1

namespace _05TheBiggestOf3Numbers
{
    class TheBiggestOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                if (a >= c)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
