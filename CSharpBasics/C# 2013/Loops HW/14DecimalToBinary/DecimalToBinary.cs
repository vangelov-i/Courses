using System;
using System.Linq;

namespace _14DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
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
}
