using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3LastDigit
{
    class LastDigit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int lastDigit = n % 10;
            Console.WriteLine(lastDigit);

        }
    }
}
