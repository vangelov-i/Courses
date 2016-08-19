using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P8Numbers1toN
{
    class Numbers1toN
    {
        static void Main()
        {
            Console.Write("Please enter a valid integer number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1 ; i <= number ; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
