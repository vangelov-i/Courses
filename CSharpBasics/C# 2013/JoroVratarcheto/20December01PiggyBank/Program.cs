using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//08:10 - 08:35
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int tankPrice = int.Parse(Console.ReadLine());
            int partiesPerMonth = int.Parse(Console.ReadLine());
            // 2 lv a day // -5lv per party

            int savingsPerMonth = (30 - partiesPerMonth) * 2;
            savingsPerMonth -= partiesPerMonth * 5; ;
            double monthsNeeded = (double)tankPrice / savingsPerMonth;
            monthsNeeded = Math.Ceiling(monthsNeeded);
            int years = (int)monthsNeeded / 12;
            double months = monthsNeeded % 12;
            int roundedMonths = (int)months + 1;
            if (months % 1 != 0)
            {
                roundedMonths = (int)months + 1;
            }
            else
            {
                roundedMonths = (int)months;
            }

            if (monthsNeeded > 0)
            {
                Console.WriteLine("{0} years, {1} months", years, roundedMonths);
            }
            else
            {
                Console.WriteLine("never");
            }


        }
    }
}