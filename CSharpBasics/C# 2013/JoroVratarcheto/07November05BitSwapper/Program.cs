using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//16:18 - 17:13  //  19:05 - 19:35  // 1:30 min  100 tochki ! 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            //long a = 4294967280L;
            //long b = 15L;                                  // IF 'b' is (int) the ^ result is wrong?!?!
            //Console.WriteLine(Convert.ToString(a, 2));
            //a = a ^ (b << 28);
            //Console.WriteLine(Convert.ToString(15 << 28, 2));
            //Console.WriteLine(Convert.ToString(a, 2));
            long[] nums = new long[4];
            for (int i = 0; i < 4; i++)
            {
                nums[i] = long.Parse(Console.ReadLine());
            }

            string temp1 = string.Empty;
            string temp2 = string.Empty;
            int n1 = 0;
            int p1 = 0;
            int n2 = 0;
            int p2 = 0;
            long mask = 0;

            long group1 = 0;
            long group2 = 0;
            while (true)
            {
                temp1 = Console.ReadLine();
                if (temp1 == "End")
                {
                    break;
                }
                temp2 = Console.ReadLine();
                n1 = int.Parse(temp1[0].ToString());
                p1 = int.Parse(temp1[2].ToString());
                n2 = int.Parse(temp2[0].ToString());
                p2 = int.Parse(temp2[2].ToString());
                group1 = (long)(nums[n1] >> (4 * p1)) & 15;
                group2 = (long)(nums[n2] >> (4 * p2)) & 15;
                mask = (int)(group1 ^ group2);
                nums[n1] = (long)(nums[n1] ^ (mask << (4 * p1)));
                nums[n2] = (long)(nums[n2] ^ (mask << (4 * p2)));

            }

            foreach (var item in nums)
            {
                Console.WriteLine((uint)item);
            }

        }
    }
}
