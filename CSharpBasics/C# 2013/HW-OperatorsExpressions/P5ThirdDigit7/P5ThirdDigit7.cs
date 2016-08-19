using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5ThirdDigit7
{
    class P5ThirdDigit7
    {
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            bool thirdDigit = (n/100) % 10 == 7;  // used formula => nDigit = (number / 10^(n-1)) %10 
                                                  //n - position of the number we want to check. 
                                                  //Source : Problem 4 , exercise Operators and Expressions
            Console.WriteLine("Is it true that the third digit (right to left) of the number {0} is 7?",n);
            Console.WriteLine(thirdDigit);
        }
    }
}
