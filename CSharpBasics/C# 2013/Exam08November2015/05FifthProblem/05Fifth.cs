using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 05 - Fifth
class Program
{
    static void Main()
    {
        checked
        {

            long first = long.Parse(Console.ReadLine());
            long second = long.Parse(Console.ReadLine());

            //long combined = 0L;
            string combined = string.Empty;
            long curBit = -1;

            if (first >= second)
            {

                for (int i = 31; i >= 0; i--)
                {
                    curBit = (first & (1 << i));
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }
                    curBit = second & (1 << i);
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }

                }
                Console.WriteLine(Convert.ToUInt64(combined, 2));
            }

            else
            {
                for (int i = 31; i >= 0; i -= 2)
                {
                    curBit = (first & (1 << i));
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }
                    curBit = first & (1 << i - 1);
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }



                    curBit = second & (1 << i);
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }
                    curBit = second & (1 << i-1);
                    if (curBit == 0)
                    {
                        combined += 0;
                    }
                    else
                    {
                        combined += 1;
                    }
                }
                Console.WriteLine(Convert.ToUInt64(combined, 2));
            }


        }
    }
}