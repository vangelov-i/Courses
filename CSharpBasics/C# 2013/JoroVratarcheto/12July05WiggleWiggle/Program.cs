using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 13:40 - 15:25 ->  62/100 + 10min -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            //long a = long.MaxValue;
            //Console.WriteLine(Convert.ToString(a,2));
            string[] nums = Console.ReadLine().Split(' ');

            long[] numbers = new long[nums.Length];
            long[] twinNumbers = new long[nums.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(nums[i]);
                twinNumbers[i] = long.Parse(nums[i]);
            }

            long currBitA = -1L;
            long currBitB = -1L;
            long mask = 1L;
            for (int i = 0; i < numbers.Length; i += 2)
            {

                for (int j = 0; j < 63; j += 2)
                {
                    if (j == 32)
                    {
                        Console.WriteLine();
                    }
                    currBitA = numbers[i] & (mask << j);
                    currBitB = numbers[i + 1] & (mask << j);

                    if (currBitA != 0)
                    {
                        twinNumbers[i + 1] = twinNumbers[i + 1] | (mask << j);
                    }
                    else
                    {
                        twinNumbers[i + 1] = twinNumbers[i + 1] & (~(mask << j));
                    }

                    if (currBitB != 0)
                    {
                        twinNumbers[i] = twinNumbers[i] | (mask << j);
                    }
                    else
                    {
                        twinNumbers[i] = twinNumbers[i] & (~(mask << j));
                    }
                }
            }
            long maskInvert = -1L;
            string binary = string.Empty;
            for (int i = 0; i < twinNumbers.Length; i++)
            {
                //twinNumbers[i] = twinNumbers[i] & (~(mask << 63));
                twinNumbers[i] = twinNumbers[i] ^ maskInvert;
                twinNumbers[i] = twinNumbers[i] & (~(mask << 63));
                binary = Convert.ToString(twinNumbers[i], 2);
                Console.WriteLine("{0} {1}",Convert.ToInt64(binary,2), binary.PadLeft(63,'0'));
            }

        }
    }
}