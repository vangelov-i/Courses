using System;
using System.Linq;

namespace _16DecToHex
{
    class DecToHex
    {
        static void Main()
        {
            long numberDec = long.Parse(Console.ReadLine());
            long reminder = 0;
            bool numberDecIsZero = false;
            string hex = string.Empty;
            while (!numberDecIsZero)
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
                    numberDecIsZero = true;
                }
            }
            string output = new string(hex.Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
