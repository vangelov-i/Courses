using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:10 - 12:30 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            string[] input = Console.ReadLine().Split('\\');

            Dictionary<string, decimal> months = new Dictionary<string, decimal>
            {
                {"Jan", 31m},
                {"Feb", 28m},
                {"March", 31m},
                {"Apr", 30m},
                {"May", 31m},
                {"June", 30m},
                {"July", 31m},
                {"Aug", 31m},
                {"Sept", 30m},
                {"Oct", 31m},
                {"Nov", 30m},
                {"Dec", 31m},

            };

            decimal hourly = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);

            decimal workDaysInMonth = months[input[0]] - 10;

            decimal earned = workDaysInMonth * hoursPerDay * hourly;
            if (earned > 700)
            {
                earned = earned + earned * 0.1m;
            }

            if (earned >= itemPrice)
            {
                Console.WriteLine("Money left = {0:F2} leva.", earned - itemPrice);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - earned);
            }
        }
    }
}