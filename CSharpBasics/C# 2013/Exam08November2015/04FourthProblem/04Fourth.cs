using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 04 - Fourth
class Program
{
    static void Main()
    {
        checked
        {

            Dictionary<string, int> daysOfWeek = new Dictionary<string, int>()
            {
                {"Monday", 1},
                {"Tuesday", 2},
                {"Wednesday", 3},
                {"Thursday", 4},
                {"Friday", 5},
                {"Saturday", 6},
                {"Sunday", 7}
            };


            long sum = 0L;
            long braNum = 0L;
            long name = 0L;
            long countPerf = 0L;

            string temp = string.Empty;

            while (true)
            {

                string[] input = Console.ReadLine().Split('\\');
                if (input[0] == "Enough dates!")
                {
                    break;
                }
                sum += daysOfWeek[input[0]];

                for (int i = 0; i < input[1].Length; i++)
                {
                    sum += long.Parse(input[1][i].ToString());
                }

                if (input[2].Length == 3)
                {
                    temp = Convert.ToString(input[2][0]) + input[2][1];
                    braNum = long.Parse(temp);
                    braNum = braNum * (int)input[2][2];
                }
                else
                {
                    temp = Convert.ToString(input[2][0]) + input[2][1] + input[2][2];
                    braNum = long.Parse(temp);
                    braNum = braNum * (int)input[2][3];
                }
                sum += braNum;

                name = (long)input[3][0] * input[3].Length;
                sum -= name;

                if (sum >= 6000)
                {
                    countPerf++;
                    Console.WriteLine("{0} is perfect for you.", input[3]);
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", input[3]);
                }
                sum = 0L;

            }

            Console.WriteLine(countPerf);


        }
    }
}