using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10FibonacciNumbers
{
    class P10FibnacciNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number \"n\" to see the first \"n\" members of the Fibonacci sequence: ");
            uint n = uint.Parse(Console.ReadLine());
            uint a = 1;
            uint b = 0;
            uint c = 0;

            for (uint i = 0; i < n; i++)
            {
                Console.Write("{0}, ", c);
                c = a + b;
                a = b;
                b = c;
            }
            Console.WriteLine();
            
            
            
            // copied  from Svetlio !!
            
            
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0, b = 1 ; b <= n ; i = i + b , b += i)
            //{
            //    Console.Write("{0}, {1}, ",i , b);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
        }
    }
}