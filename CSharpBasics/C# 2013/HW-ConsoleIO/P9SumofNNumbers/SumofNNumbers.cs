using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9SumofNNumbers
{
    class SumofNNumbers
    {
        static void Main()
        {
            Console.Write("Please enter how many numbers would you like to sum: ");
            int length = int.Parse(Console.ReadLine());

            double result = 0;
            for (double i = 1 ; i <= length ; i++)
            {
                Console.Write("Please enter number [{0}]: ", i);
                double number = double.Parse(Console.ReadLine());
                result += number;
            }
            Console.WriteLine("The sum of your numbers is {0}", result);
        }
    }
}
