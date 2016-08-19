using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 22:05 - 22:25 // 23:50 - 00:30 // 10:55 - 11:05 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            string[] s = Console.ReadLine().Split(' ');
            string input = string.Concat(s);
            int j = int.Parse(Console.ReadLine());

            int index = 0;
            int[] sums = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                index = i;
                for (int k = 0; k <= j; k++)
                {
                    sums[i] += int.Parse(s[index]);
                    index = (index + int.Parse(s[index])) % (s.Length);
                }
            }
            Console.WriteLine("max sum = {0}",sums.Max());
            //foreach (var item in sums)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}