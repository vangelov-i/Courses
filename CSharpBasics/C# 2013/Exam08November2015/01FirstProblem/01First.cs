using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 01 - First
class Program
{
    static void Main()
    {
        checked
        {
            decimal builders = decimal.Parse(Console.ReadLine());
            decimal receptionists = decimal.Parse(Console.ReadLine());
            decimal chamermaids = decimal.Parse(Console.ReadLine());
            decimal technicians = decimal.Parse(Console.ReadLine());
            decimal others = decimal.Parse(Console.ReadLine());
            decimal nikiSalary = decimal.Parse(Console.ReadLine());
            decimal rateUSD = decimal.Parse(Console.ReadLine());
            decimal mySalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            nikiSalary = nikiSalary * rateUSD;
            decimal neededMoney = builders * 1500.04m + receptionists * 2102.10m + chamermaids * 1465.46m +
                technicians * 2053.33m + others * 3010.98m + nikiSalary + mySalary;


            //Dictionary<string, decimal> salaries = new Dictionary<string, decimal>()
            //{
            //    {"Builders", 1500.04m},
            //    {"Receptionists", 2102.10m},
            //    {"Chamermaids", 1465.46m},
            //    {"Technicians", 2053.33m},
            //    {"Others", 3010.98m}
            //};

            Console.WriteLine("The amount is: {0:F2} lv.", neededMoney);
            if (budget >= neededMoney)
            {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", budget - neededMoney);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", neededMoney - budget);
            }


        }
    }
}