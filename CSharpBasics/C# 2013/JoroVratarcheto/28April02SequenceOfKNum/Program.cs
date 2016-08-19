using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// za 1:10 min  -> 70/100  // 13:30 - 14:10  -> 100/100  (total 1:50 min)
namespace _28April02SequenceOfKNum
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(Console.ReadLine());

            int k1 = k;
            List<string> digits = new List<string>();

            foreach (var digit in input)
            {
                digits.Add(digit);
            }

            string test = string.Empty;
            string temp = string.Empty;
            List<string> listOutput = new List<string>();
            int counter = 1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (digits[i] == digits[i + 1])
                {
                    counter++;
                }
                else if (digits[i] != digits[i + 1])
                {
                    if (i != input.Length -2 && counter % k == 0)
                    {
                        counter = 1;
                        continue;
                    }
                    else
                    {
                        for (int j = 0; j < counter % k; j++)
                        {
                            test += digits[i];
                            temp = digits[i];
                            listOutput.Add(temp);
                            temp = string.Empty;
                        }
                        counter = 1;
                    }
                }
                if (counter % k != 0 && i == input.Length - 2)
                {
                    for (int j = 0; j < counter % k; j++)
                    {
                        test += digits[i];
                        temp = digits[i + 1];
                        listOutput.Add(temp);
                        temp = string.Empty;
                    }
                }
            }

            if (listOutput.Count > 0)
            {
                Console.Write("{0}", listOutput[0]);
            }
            for (int i = 1; i < listOutput.Count; i++)
            {
                Console.Write(" {0}", listOutput[i]);
            }
            Console.WriteLine();


        }
    }
}
