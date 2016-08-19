using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OperatorsExpressions
{
    class ExersiceP4
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter which digit of that number you want to show (right to left): ");
            int n = int.Parse(Console.ReadLine());
            int nDigit=number/((int)Math.Pow(10, n - 1))%10;
            Console.WriteLine(nDigit);
        }
    }
}
