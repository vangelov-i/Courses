using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11IntervalDividableByGivenNumber
{
    class P11IntervalDividableByGivenNumber
    {
        static void Main()
        {
            Start:
            Console.Write("Please enter a positive integer number as a starting point: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Please enter a positive integer number as a finish point: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers between {0} and {1} which can be divided by 5 with a reminder 0 are: ", start, end);
            int counter = 0;
            for (int i = start ; i <= end ; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i +", ");
                    counter = counter + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("This is {0} numbers", counter);
            Console.WriteLine();

            goto Start;
        }
    }
}
