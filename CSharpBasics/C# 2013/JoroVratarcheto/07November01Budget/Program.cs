using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//14:45 - 15:15
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int money = int.Parse(Console.ReadLine());
            int gointOut = int.Parse(Console.ReadLine());
            int daysParents = int.Parse(Console.ReadLine()) * 2;

            int outExp = (int)(money * 0.03);
            money = money - 150 - gointOut*outExp - gointOut*10;
            money = money - (22 - gointOut) * 10;
            money = money - (8 - daysParents)*20;
            if (money > 0)
            {
                Console.WriteLine("Yes, leftover {0}.", money);
            }
            else if (money < 0)
            {
                Console.WriteLine("No, not enough {0}.", Math.Abs(money));
            }
            else
            {
                Console.WriteLine("Exact Budget.");
            }


        }
    }
}
