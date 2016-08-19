using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11:25 - 12:05

class Program
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());

        if (n != 0)
        {
            string binaryN = Convert.ToString(n, 2);
            string tempFr = string.Empty;
            string tempAlone = string.Empty;
            string friends = string.Empty;

            for (int i = 0; i < binaryN.Length; i++)
            {
                if (binaryN[0] == binaryN[1] && i == 0)
                {
                    tempFr += binaryN[0];
                }
                else if (binaryN[0] != binaryN[1] && i == 0)
                {
                    tempAlone += binaryN[i];
                }
                else if (i > 0 && binaryN[i] == binaryN[i - 1])
                {
                    tempFr += binaryN[i];
                }
                else if (i > 0 && binaryN[i] != binaryN[i - 1])
                {
                    if (tempFr != string.Empty)
                    {
                        friends += tempFr;
                        tempFr = string.Empty;
                    }
                    if (i < binaryN.Length - 1 && binaryN[i] == binaryN[i + 1])
                    {
                        tempFr += binaryN[i];
                    }
                    else
                    {
                        tempAlone += binaryN[i];
                    }
                }
                if (i == binaryN.Length - 1 && tempFr != string.Empty)
                {
                    friends += tempFr;
                }
            }

            if (friends != string.Empty)
            {
                Console.WriteLine(Convert.ToInt64(friends, 2));
            }
            else
            {
                Console.WriteLine(0);
            }
            if (tempAlone != string.Empty)
            {
                Console.WriteLine(Convert.ToInt64(tempAlone, 2));
            }
            else
            {
                Console.WriteLine(0);
            }
        }
        else
        {
            Console.WriteLine(0);
            Console.WriteLine(0);
        }

    }
}

