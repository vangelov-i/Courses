using System;
namespace _13ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            //Write a program that safely compares floating-point numbers (double) 
            //with precision eps = 0.000001. Note that we cannot directly compare 
            //two floating-point numbers a and b by a==b because of the nature of 
            //the floating-point arithmetic. Therefore, we assume two numbers are equal
            //if they are more closely to each other than a fixed constant eps.

            Console.Write("Please enter the first double number: ");
            double numberA = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second double number: ");
            double numberB = double.Parse(Console.ReadLine());
            decimal difference = (decimal)Math.Abs(numberA - numberB); 
            // *can't understand why in this case type double can't be implicity converted to decimal??
            // *using decimal because in some cases the difference can't be shown 
            //  correctly by using type double (when there are 8+ digits after the floating point)
            // *Math.Abs always returns a positive number

            difference = Math.Round(difference, 8);
            bool equal = difference < 0.000001M;  // this line is kind of unnecessary
            if (difference > 0.000001M)
            {
                Console.WriteLine("{0}. The difference of {1} is too big (>eps)", equal, difference);
            }
            else if (difference < 0.000001M)
            {
                Console.WriteLine("{0}. The difference {1} < eps", equal, difference);
            }
            else
            {
                Console.WriteLine("{0}. Border case. The difference of 0.000001 == eps.\nWe consider the numbers are different.", equal);
            }
        }
    }
}