using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:30 - 12:50 -> 100!
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string[] input = Console.ReadLine().Split('\\');
            string left = input[0];
            string right = input[1];
            string command = input[2];

            if (command == "join")
            {
                List<int> joined = new List<int>();

                for (int i = 0; i < left.Length; i++)
                {
                    for (int j = 0; j < right.Length; j++)
                    {
                        if (left[i] == right[j])
                        {
                            joined.Add((int)left[i]);
                        }
                    }
                }
                joined.Sort();
                foreach (var symbol in joined)
                {
                    Console.Write((char)symbol);
                }
                Console.WriteLine();
            }
            else if (command == "left exclude")
            {
                bool equalChars = false;
                List<int> leftExcl = new List<int>();

                for (int i = 0; i < right.Length; i++)
                {
                    for (int j = 0; j < left.Length; j++)
                    {
                        if (right[i] == left[j])
                        {
                            equalChars = true;
                        }
                    }
                    if (!equalChars)
                    {
                        leftExcl.Add((int)right[i]);
                    }
                    equalChars = false;
                }
                leftExcl.Sort();
                foreach (var symbol in leftExcl)
                {
                    Console.Write((char)symbol);
                }
                Console.WriteLine();
            }
            else if (command == "right exclude")
            {
                bool equalChars = false;
                List<int> leftExcl = new List<int>();

                for (int i = 0; i < left.Length; i++)
                {
                    for (int j = 0; j < right.Length; j++)
                    {
                        if (left[i] == right[j])
                        {
                            equalChars = true;
                        }
                    }
                    if (!equalChars)
                    {
                        leftExcl.Add((int)left[i]);
                    }
                    equalChars = false;
                }
                leftExcl.Sort();
                foreach (var symbol in leftExcl)
                {
                    Console.Write((char)symbol);
                }
                Console.WriteLine();
            }



        }
    }
}