using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 15:20 - 15:45  100 !!! 
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            //string[] array = input.Split(' ');
            long letttersSum = 0;
            long symbolsSum = 0;
            long numbersSum = 0;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().ToUpper();
                char[] array = input.ToCharArray();
                for (int j = 0; j < input.Length; j++)
                {
                    if (Char.IsNumber(input[j]))
                    {
                        numbersSum += (input[j] - 48)*20;
                    }
                    else if (Char.IsLetter(input[j]))
                    {
                        letttersSum += (input[j] - 64) * 10;
                    }
                    else if (input[j] != ' ' && input[j] != '\t' && input[j] != '\r' && input[j] != '\n')
                    {
                        symbolsSum += 200;
                    }
                }

            }
            Console.WriteLine(letttersSum);
            Console.WriteLine(numbersSum);
            Console.WriteLine(symbolsSum);
        }
    }
}
