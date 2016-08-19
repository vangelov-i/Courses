using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 02 - Second
class Program
{
    static void Main()
    {
        checked
        {

            decimal seconds = 0L;
            decimal counter = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split(':');
                if (input[0] == "Quit")
                {
                    break;
                }
                counter++;
                seconds += decimal.Parse(input[0]) * 60;
                seconds += decimal.Parse(input[1]);



            }

            decimal avarege = seconds / counter;

            if (avarege < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (avarege < 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }
            Console.WriteLine("Games - {0} \\ Average seconds - {1}", (long)counter, Math.Ceiling(avarege));

        }
    }
}