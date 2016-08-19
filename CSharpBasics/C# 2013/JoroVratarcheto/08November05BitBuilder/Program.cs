using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 21:22 - 22:20  // 00:12 - 0:50 ; 

class Program
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());

        bool quit = false;
        while (quit == false)
        {
            string position = Console.ReadLine();
            if (position == "quit")
            {
                quit = true;
                break;
            }
            else
            {
                string action = Console.ReadLine();
                int bitPos = int.Parse(position);
                switch (action)
                {
                    case "flip":
                        number ^= (1 << bitPos);
                        break;
                    case "remove":
                        if (bitPos == 0)
                        {
                            number = number >> 1;
                        }
                        else
                        {
                            long temp1 = (long)Math.Pow(2, bitPos) - 1;
                            temp1 = temp1 & number;
                            number = number >> bitPos +1;
                            number = number << bitPos;
                            number = number | temp1;
                        }
                        break;
                    case "insert":
                        long temp = (long)Math.Pow(2, (bitPos)) -1;
                        temp = temp & number;
                        number = number >> bitPos;
                        number = number << 1;
                        number = number | 1;                            // vazmojni greshki v tozi case
                        number = number << bitPos;                      // svyrzani s >> operaciite +/- 1 pri bitPos
                        number = number | temp;
                        break;
                    case "skip":
                        break;
                }
            }
        }
        Console.WriteLine(number);
    }
}
