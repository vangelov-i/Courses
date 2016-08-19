using System;

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011)
//and performs the following:
//•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//•	Prints on the console the number in reversed order: dcba (in our example 1102).
//•	Puts the last digit in the first position: dabc (in our example 1201).
//•	Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:

//n	    sum of digits	reversed	last digit      second and third 
//                                  in front        digits exchanged	
//2011	       4	    1102	    1201	        2101
//3333	       12	    3333	    3333	        3333
//9876	       30	    6789	    6987	        9786

namespace _06FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int fourthDig = n % 10;
            int thirdDig = (n / 10) % 10;
            int secondDig = (n / 100) % 10;
            int firstDig = (n / 1000) % 10;

            Console.WriteLine("{0}", firstDig + secondDig + thirdDig + fourthDig);
            Console.WriteLine("{0}{1}{2}{3}", fourthDig, thirdDig, secondDig, firstDig);
            Console.WriteLine("{0}{1}{2}{3}", fourthDig, firstDig, secondDig, thirdDig);
            Console.WriteLine("{0}{1}{2}{3}", firstDig, thirdDig, secondDig, fourthDig);
        }
    }
}
