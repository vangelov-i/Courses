using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 13:00 - 13:20 
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            string input = Console.ReadLine().ToLower();
            int jumpOdd = int.Parse(Console.ReadLine());
            int jumpEven = int.Parse(Console.ReadLine());


            string[] arrInput = input.Split(' ');
            input = string.Empty;
            foreach (var str in arrInput)
            {
                input += str;
            }
            //int oddCount = 1;
            //int evenCount = 2;
            string oddWord = string.Empty;
            string evenWord = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddWord += input[i].ToString();
                }
                else
                {
                    evenWord += input[i].ToString();
                }
            }


            long calcOdds = 0L;
            for (int i = 0; i < oddWord.Length; i++)
            {
                if ((i + 1) % jumpOdd != 0)
                {
                    calcOdds += (int)oddWord[i];
                }
                else
                {
                    calcOdds *= (int)oddWord[i];
                }
            }

            long calcEvens = 0L;
            for (int i = 0; i < evenWord.Length; i++)
            {
                if ((i + 1) % jumpEven != 0)
                {
                    calcEvens += (int)evenWord[i];
                }
                else
                {
                    calcEvens *= (int)evenWord[i];
                }
            }


            Console.WriteLine("Odd: {0:X}", calcOdds);
            Console.WriteLine("Even: {0:X}", calcEvens);


        }
    }
}