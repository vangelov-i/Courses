using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:19 - 11:27 -> 100 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            decimal price = decimal.Parse(Console.ReadLine());
            decimal nBank = decimal.Parse(Console.ReadLine());
            decimal interestBank = decimal.Parse(Console.ReadLine());
            decimal friendInterest = decimal.Parse(Console.ReadLine());

            decimal fvBank = (decimal)Math.Pow(((double)1 + (double)interestBank), (double)nBank) * price;
            decimal fvFriend = price + price*friendInterest;

            if (fvBank < fvFriend)
            {
                Console.WriteLine("{0:F2} Bank", fvBank);
            }
            else
            {
                Console.WriteLine("{0:F2} Friend", fvFriend);
            }

        }
    }
}