using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 17:00 - 18:00 || 12:20 - 14:00  -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            int n = int.Parse(Console.ReadLine());
            string word = Console.ReadLine().ToUpper();
            int[,] matrix = new int[n, n];
            int index = 0;

            int countWord = 0;
            int up = 0;
            int j = 0;
            int i = 0;

            while (countWord < n * n)
            {
                i = up;
                j = up;
                while (j <= n - i - 1)
                {
                    index = countWord % word.Length;
                    matrix[i, j] = ((int)(word[index]) - 64) * 10;
                    //Console.Write("{0,3}", matrix[i, j]);
                    j++;
                    countWord++;
                }
                //Console.WriteLine();
                i++;
                j--;
                while (i <= n - (n - j))
                {
                    index = countWord % word.Length;
                    matrix[i, j] = ((int)(word[index]) - 64) * 10;
                    //Console.Write("{0,3}", matrix[i, j]);
                    i++;
                    countWord++;
                }
                //Console.WriteLine();
                i--;
                j--;
                while (j >= n - i - 1)
                {
                    index = countWord % word.Length;
                    matrix[i, j] = ((int)(word[index]) - 64) * 10;
                    //Console.Write("{0,3}", matrix[i, j]);
                    j--;
                    countWord++;
                }
                //Console.WriteLine();
                j++;
                i--;
                while (i > up)
                {
                    index = countWord % word.Length;
                    matrix[i, j] = ((int)(word[index]) - 64) * 10;
                    //Console.Write("{0,3}", matrix[i, j]);
                    i--;
                    countWord++;
                }
                //Console.WriteLine();
                up++;
            }
            //Console.WriteLine();
            //Console.WriteLine();

            int currWeight = 0;
            int maxWeight = 0;
            int row = -1;
            for (int q = 0; q < n; q++)
            {
                for (int p = 0; p < n; p++)
                {
                    currWeight += matrix[q, p];
                }
                if (currWeight > maxWeight)
                {
                    row = q;
                }
                maxWeight = Math.Max(currWeight, maxWeight);
                currWeight = 0;
            }

            Console.WriteLine("{0} - {1}", row, maxWeight);

        }
    }
}