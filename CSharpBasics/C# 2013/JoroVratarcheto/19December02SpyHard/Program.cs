using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 12:50 - 14:00 ciklaj //  15 min sled kraq - 490/500   inache 420/500
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            string msg = Console.ReadLine().ToUpper();

            string result = n.ToString();
            result += msg.Length.ToString();

            int sum = 0;
            for (int i = 0; i < msg.Length; i++)
            {
                if (Char.IsLetter(msg[i]))
                {
                    sum += (int)msg[i] - 64;
                }
                else
                {
                    sum += (int)msg[i];
                }
            }

            if (n == 2)
            {
                string binary = Convert.ToString(sum, 2);
                result += binary;
                Console.WriteLine(result);
            }
            else if (n == 8)
            {
                string asd = Convert.ToString(sum, 8);
                result += asd;
                Console.WriteLine(result);
            }
            else if (n < 10)
            {
                string binary = string.Empty;
                int reminder = 0;
                while (true)
                {
                    reminder = (int)sum % n;
                    sum /= n;
                    binary += reminder;
                    if (sum == 0)
                    {
                        break;
                    }
                }
                string output = new string(binary.Reverse().ToArray());
                result += output;
                Console.WriteLine(result);
            }
            else
            {
                result += sum.ToString();
                Console.WriteLine(result);
            }


        }
    }
}