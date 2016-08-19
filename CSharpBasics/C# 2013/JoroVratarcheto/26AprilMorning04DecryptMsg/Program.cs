using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 11:06 - 11:41 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            // print decrypted msgs and their count 
            // A to M ==> N to Z (A=N , B = O etc...
            // N to Z ==> A to M
            // + = " " , % = ',' , & = '.' , # = ? , $ = ! 
            // digits stay the same way
            Dictionary<char, char> symbols = new Dictionary<char, char>
            {
                {'+', ' '},
                {'%', ','},
                {'&','.'},
                {'#','?'},
                {'$','!'}
            };

            bool start = false;
            List<string> messages = new List<string>();
            string temp = string.Empty;
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "end")
                {
                    break;
                }
                else if (input.ToLower() == "start" || input == "")
                {
                    start = true;
                    continue;
                }
                if (start)
                {
                    for (int i = 0; i < input.Length; i++)
                    {

                        if (Char.IsLetter(input[i]))
                        {
                            if (input[i] > 64 && input[i] < 78)
                            {
                                temp += (char)(input[i] + 13);
                            }
                            else if (input[i] > 77 && input[i] < 91)
                            {
                                temp += (char)(input[i] - 13);
                            }
                            else if (input[i] > 96 && input[i] < 110)
                            {
                                temp += (char)(input[i] + 13);
                            }
                            else if (input[i] > 109 && input[i] < 123)
                            {
                                temp += (char)(input[i] - 13);
                            }
                        }
                        else if (Char.IsDigit(input[i]))
                        {
                            temp += int.Parse(input[i].ToString());
                        }
                        else if ((input[i] < 39 && input[i] > 34) || input[i] == 43)
                        {
                            temp += symbols[input[i]];
                        }
                    }
                    temp = new string(temp.Reverse().ToArray());
                    messages.Add(temp);
                    temp = string.Empty;
                }

            }

            if (messages.Count > 0)
            {
                Console.WriteLine("Total number of messages: {0}", messages.Count);
                foreach (var message in messages)
                {
                    Console.WriteLine(message);
                }
            }
            else
            {
                Console.WriteLine("No message received.");
            }
        }
    }
}