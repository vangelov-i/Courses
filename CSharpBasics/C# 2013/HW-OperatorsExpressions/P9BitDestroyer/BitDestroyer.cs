using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9BitDestroyer
{
    class BitDestroyer
    {
        static void Main()
        {
            start:
            Console.Write("Please enter a valid integer number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in binary is: {0} ", Convert.ToString(n, 2));
            Console.Write("Please enter a bit\'s position \"p\" that you want to switch to [0]: ");
            int p = int.Parse(Console.ReadLine());
            int mask = ~(1 << p);
            int newNumber = n & mask;
            Console.Write("Your new number in binary is: ");
            Console.WriteLine(Convert.ToString(newNumber, 2).PadLeft(8, '0'));
            Console.WriteLine("Your new integer number is: {0}", newNumber);
            Console.WriteLine("_", 20);
            goto start;

            /// i think i dont quiet get what exactly is asked to be done
        }

    }
}
