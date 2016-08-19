using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//15:20 - 15:55 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int setCount = int.Parse(Console.ReadLine());
            int numsInSet = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();

            int[,] sets = new int[setCount,numsInSet];
            int temp = 0;
            int counter = 0;
            int mostNumsSet = -1;
            for (int i = 0; i < setCount; i++)
            {
                for (int j = 0; j < numsInSet; j++)
                {
                    sets[i,j] = int.Parse(Console.ReadLine());
                    if (oddOrEven == "odd" && sets[i, j] % 2 != 0)
                    {
                        temp++;
                    }
                    else if (oddOrEven == "even" && sets[i, j] % 2 == 0)
                    {
                        temp++;
                    }
                }
                if (Math.Max(temp, counter) == temp && counter != temp)
                {
                    mostNumsSet = i;
                }
                counter = Math.Max(temp, counter);
                temp = 0;
            }
            mostNumsSet++;
            string setName = string.Empty;
            //Console.WriteLine();
            //Console.WriteLine(mostNumsSet);
            switch (mostNumsSet)
            {
                case 1:
                    setName = "First";
                    break;
                case 2:
                    setName = "Second";
                    break;
                case 3:
                    setName = "Third";
                    break;
                case 4:
                    setName = "Fourth";
                    break;
                case 5:
                    setName = "Fifth";
                    break;
                case 6:
                    setName = "Sixth";
                    break;
                case 7:
                    setName = "Seventh";
                    break;
                case 8:
                    setName = "Eight";
                    break;
                case 9:
                    setName = "Ninth";
                    break;
                default:
                    setName = "Tenth";
                    break;
            }
            if (counter != 0)
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", setName, oddOrEven, counter);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
