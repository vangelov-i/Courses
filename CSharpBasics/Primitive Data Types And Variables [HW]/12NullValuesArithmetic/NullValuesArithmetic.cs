using System;

namespace _12NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer
            //and to a double variable. Try to print these variables
            //at the console. Try to add some number or the null literal
            //to these variables and print the result.

            int? number1 = null;
            double? number2 = null;
            Console.WriteLine(number1 + " "  + number2);
            number1 = number1 + 5;
            number2 = number2 + 0.123;
            Console.WriteLine("number1 + 5 = {0}", number1);
            Console.WriteLine("number2 + 0.123 = {0}", number2);
        }
    }
}
