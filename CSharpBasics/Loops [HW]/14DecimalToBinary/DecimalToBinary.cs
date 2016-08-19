using System;
using System.Linq;

//Using loops write a program that converts an integer number to 
//its binary representation. The input is entered as long. The 
//output should be a variable of type string. Do not use the built-in 
//.NET functionality. Examples:

//decimal	binary
//0	        0
//3	        11
//43691	    1010101010101011
//236476736	1110000110000101100101000000

class DecimalToBinary
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        string binary = string.Empty;
        int reminder = 0;
        bool numberIsZero = false;
        while (!numberIsZero)
        {
            reminder = (int)number % 2;
            number /= 2;
            binary += reminder;
            if (number == 0)
            {
                numberIsZero = true;
            }
        }
        string output = new string(binary.Reverse().ToArray());
        Console.WriteLine(output);
    }
}
