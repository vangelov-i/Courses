using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:35 - 12:50 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            // contract month - 3 per week
            // when having 1 less travel per week than a contract month  = family months

            string year = Console.ReadLine();
            double contract = double.Parse(Console.ReadLine());
            double family = double.Parse(Console.ReadLine());

            double normalMonths = 0.6;

            double total = contract * 4 * 3;
            total += family * 4;
            total += (12 - contract - family) * 12 * normalMonths;

            if (year == "leap")
            {
                total += total * 0.05;
            }
            Console.WriteLine((int)total);

        }
    }
}