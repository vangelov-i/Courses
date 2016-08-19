using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 3 chasa  490 tochki !!!
//14:00 - 14:35   - 100 tochki
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int start = int.Parse(Console.ReadLine());
            int duration = int.Parse(Console.ReadLine());

            // On avarege Didko eats 1 watermelon and one melon per day for the whole week
            int mellons = 0;
            int waterM = 0;

            int reminder = duration % 7;

            //if (reminder == 0)
            //{
            //    Console.WriteLine("Equal amout: {0}", duration);
            //}
            if (reminder != 0)
            {
                for (int i = 0; i < reminder; i++)
                {
                    if (start == 8)
                    {
                        start = 1;
                    }
                    if (start == 1)
                    {
                        waterM++;
                    }
                    else if (start == 2)
                    {
                        mellons += 2;
                    }
                    else if (start == 3)
                    {
                        waterM++;
                        mellons++;
                    }
                    else if (start == 4)
                    {
                        waterM += 2;
                    }
                    else if (start == 5)
                    {
                        waterM += 2;
                        mellons += 2;
                    }
                    else if (start == 6)
                    {
                        waterM++;
                        mellons += 2;
                    }
                    start++;
                }


            }
            if (mellons > waterM)
            {
                Console.WriteLine("{0} more melons", mellons - waterM);
            }
            else if (waterM > mellons)
            {
                Console.WriteLine("{0} more watermelons", waterM - mellons);
            }
            //else if (duration )
            //{

            //}
            else if (reminder == 0)
            {
                Console.WriteLine("Equal amount: {0}", duration);
            }
            else
            {
                Console.WriteLine("Equal amount: {0}", mellons);
            }

        }

    }
}

