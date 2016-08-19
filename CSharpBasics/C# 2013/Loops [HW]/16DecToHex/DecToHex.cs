using System;
using System.Linq;

//Using loops write a program that converts an integer number 
//to its hexadecimal representation. The input is entered as long. 
//The output should be a variable of type string. Do not use the 
//built-in .NET functionality. Examples:

//decimal	    hexadecimal
//254	        FE
//6883	        1AE3
//338583669684	4ED528CBB4

class DecToHex
{
    static void Main(string[] args)
    {
        long numberDec = long.Parse(Console.ReadLine());
        long reminder = 0;
        string hex = string.Empty;
        while (true)
        {
            reminder = numberDec % 16;
            numberDec /= 16;
            if (reminder == 10)
            {
                hex += 'A';
            }
            else if (reminder == 11)
            {
                hex += 'B';
            }
            else if (reminder == 12)
            {
                hex += 'C';
            }
            else if (reminder == 13)
            {
                hex += 'D';
            }
            else if (reminder == 14)
            {
                hex += 'E';
            }
            else if (reminder == 15)
            {
                hex += 'F';
            }
            else
            {
                hex += reminder;
            }
            if (numberDec == 0)
            {
                break;
            }
        }
        string output = new string(hex.Reverse().ToArray());
        Console.WriteLine(output);
    }
}
