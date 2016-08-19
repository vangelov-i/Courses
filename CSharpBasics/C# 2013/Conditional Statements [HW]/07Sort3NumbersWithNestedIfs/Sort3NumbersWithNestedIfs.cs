using System;

//Write a program that enters 3 real numbers and prints them 
//sorted in descending order. Use nested if statements. Don’t 
//use arrays and the built-in sorting functionality. 
//Examples:
//a	        b	    c	    result
//5	        1	    2	    5 2 1
//-2	    -2	    1	    1 -2 -2
//-2	    4	    3	    4 3 -2
//0	        -2.5	5	    5 0 -2.5
//-1.1	    -0.5	-0.1	-0.1 -0.5 -1.1

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (a >= c)
            {
                if (c >= b)
                {
                    Console.WriteLine("{0} {1} {2}", a, c, b);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b >= c)
            {
                if (c >= a)
                {
                    Console.WriteLine("{0} {1} {2}", b, c, a);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", b, a, c);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
    }
}
