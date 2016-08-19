using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23:15 - 23:25

namespace _10AprilEvening05BitsUp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int p = 6;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    number |= (1 << p);
                    //Console.WriteLine(Convert.ToString(bitsSeq, 2).PadLeft(8, '0'));
                    p -= step;
                    while (p >= 0)
                    {
                        number |= (1 << p);
                        p -= step;
                    }
                    arr[i] = number;
                }
                else if (8 + p >= 0)
                {
                    p += 8;
                    number |= (1 << p);
                    p -= step;
                    while (p >= 0)
                    {
                        number |= (1 << p);
                        p -= step;
                    }
                    arr[i] = number;
                }
                else if (16 + p >= 0)
                {
                    arr[i] = number;
                    p += 16;
                    if (i == n - 1)                           ////
                    {                                       //dobaveno sled pregled na test #13 v koito gyrmi
                        break;                              ////
                    }                                       ////
                    number = int.Parse(Console.ReadLine());
                    number |= (1 << p);
                    arr[i + 1] = number;
                    p -= step;
                    i++;
                }
                else if (24 + p >= 0)
                {
                    arr[i] = number;
                    if (i == n - 1)                           ////
                    {                                         //dobaveno sled pregled na test #13 v koito gyrmi
                        break;                                ////
                    }                                        ////
                    number = int.Parse(Console.ReadLine());
                    arr[i + 1] = number;
                    p += 24;
                    if (i == n - 2)                          ////
                    {                                       ////
                        break;                              //dobaveno sled pregled na test #13 v koito gyrmi
                    }                                      ////
                    number = int.Parse(Console.ReadLine());
                    number |= (1 << p);
                    arr[i + 2] = number;
                    p -= step;
                    i += 2;
                }
            }
            //Console.WriteLine("____________________");
            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
