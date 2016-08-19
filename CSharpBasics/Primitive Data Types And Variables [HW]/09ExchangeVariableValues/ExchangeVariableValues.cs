using System;

namespace _09ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main()
        {
            //Declare two integer variables a and b and assign
            //them with 5 and 10 and after that exchange their 
            //values by using some programming logic. Print the 
            //variable values before and after the exchange.
            //Expected Output
            //Before:
            //a = 5
            //b = 10
            //After:
            //a = 10
            //b = 5


            int a = 5;
            int b = 10;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}\nb = {1}", a, b);
            b = a;
            a += b; // this is the same as a = a + b;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            //Another way to do it:

            //int a = 5;
            //int b = 10;
            //int c = 5;
            //Console.WriteLine("Before:");
            //Console.WriteLine("a = {0}\nb = {1}", a, b);
            //a = b;
            //b = c;
            //Console.WriteLine("After:");
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
        }
    }
}
