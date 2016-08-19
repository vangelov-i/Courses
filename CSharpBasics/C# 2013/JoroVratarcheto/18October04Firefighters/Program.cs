using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:28 - 17:46 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int p = int.Parse(Console.ReadLine());
            int fighters = p;

            int totKids = 0;
            int totAdults = 0;
            int totSeniors = 0;
            while (true)
            {
                fighters = p;
                string obstacles = Console.ReadLine();
                if (obstacles == "rain")
                {
                    break;
                }

                int kids = 0;
                int adults = 0;
                int seniors = 0;

                for (int i = 0; i < obstacles.Length; i++)
                {
                    if (obstacles[i] == 'K')
                    {
                        kids++;
                    }
                    else if (obstacles[i] == 'A')
                    {
                        adults++;
                    }
                    else
                    {
                        seniors++;
                    }
                }
                if (kids <= fighters)
                {
                    totKids += kids;
                    fighters -= kids;
                }
                else
                {
                    totKids += fighters;
                    continue;
                }
                if (fighters <= 0)
                {
                    continue;
                }
                if (adults <= fighters)
                {
                    totAdults += adults;
                    fighters -= adults;
                }
                else
                {
                    totAdults += fighters;
                    continue;
                }
                if (fighters <= 0)
                {
                    continue;
                }
                if (seniors <= fighters)
                {
                    totSeniors += seniors;
                    fighters -= seniors;
                }
                else
                {
                    totSeniors += fighters;
                    continue;
                }


            }

            Console.WriteLine("Kids: {0}", totKids);
            Console.WriteLine("Adults: {0}", totAdults);
            Console.WriteLine("Seniors: {0}", totSeniors);

        }
    }
}