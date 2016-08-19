using System;

namespace Conditional_Statements_HW
{
    class ExchangeIfGreater
    {
        static void Main()
        {
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());
            float temp = num1;
            if (num1 > num2)
            {
                num1 = num2;
                num2 = temp;
                Console.WriteLine(num1 + " " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " " + num2);
            }

        }
    }
}
