using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
// 11:28 - 11:48 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            string replacement = Console.ReadLine();
            char[] array = replacement.ToArray();

            BigInteger tempSum = 0;

            for (ulong i = startNum; i < endNum; i++)
            {
                if (i % 5 == 0)
                {
                    tempSum += i;
                }
                else
                {
                    tempSum += i % 5;
                }
            }
            string sum = tempSum.ToString();
            string numToRep = string.Empty;
            if (tempSum %2 == 0)
            {
                numToRep = sum[0].ToString();
                sum = sum.Replace(numToRep, replacement);
            }
            else
            {
                numToRep = sum[sum.Length - 1].ToString();
                sum = sum.Replace(numToRep, replacement);
            }
            Console.WriteLine(sum);
        }
    }
}