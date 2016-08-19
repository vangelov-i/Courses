using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            string[] numbers = new string[n];
            int currNum = 0;
            for (int i = 0; i < n; i++)
            {
                currNum = int.Parse(Console.ReadLine());
                numbers[i] = Convert.ToString(currNum, 2).PadLeft(32, '0');
            }

            int left = 0;
            int right = 0;
            int down = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == '1')
                    {
                        if (i != n - 1 && numbers[i][j] == numbers[i + 1][j])
                        {
                            down++;
                        }
                        if (j != numbers[i].Length - 1 && i != n - 1 && numbers[i][j] == numbers[i + 1][j + 1])
                        {
                            right++;
                        }
                    }
                    if (j != numbers[i].Length - 1 && numbers[i][j + 1] == '1')
                    {
                        if (j != numbers[i].Length - 1 && i != n - 1 && numbers[i][j + 1] == numbers[i + 1][j])
                        {
                            left++;
                        }
                    }
                }
            }
            Console.WriteLine(right);
            Console.WriteLine(left);
            Console.WriteLine(down);

        }
    }
}