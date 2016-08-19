using System;

//Using loops write a program that converts a hexadecimal integer 
//number to its decimal form. The input is entered as string. The 
//output should be a variable of type long. Do not use the built-in 
//.NET functionality. Examples:

//hexadecimal	decimal
//FE	        254
//1AE3	        6883
//4ED528CBB4	338583669684

class HexaToDecNumber
{
    static void Main(string[] args)
    {
        string hexa = Console.ReadLine();
        long number = 0L;

        for (int i = 0; i < hexa.Length; i++)
        {
            int power = hexa.Length - i - 1;
            if (hexa[i] == 'A')
            {
                number += (long)(10 * Math.Pow(16, (power)));
            }
            else if (hexa[i] == 'B')
            {
                number += (long)(11 * Math.Pow(16, (power)));
            }
            else if (hexa[i] == 'C')
            {
                number += (long)(12 * Math.Pow(16, (power)));
            }
            else if (hexa[i] == 'D')
            {
                number += (long)(13 * Math.Pow(16, (power)));
            }
            else if (hexa[i] == 'E')
            {
                number += (long)(14 * Math.Pow(16, (power)));
            }
            else if (hexa[i] == 'F')
            {
                number += (long)(15 * Math.Pow(16, (power)));
            }
            else
            {
                byte parsed = (byte)(hexa[i] - '0');
                number += (long)(parsed * Math.Pow(16, (power)));
            }
        }
        Console.WriteLine(number);
    }
}
