using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 21:13 - 21:31 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            string secWord = Console.ReadLine();
            string encrypted = Console.ReadLine();

            int sum = 0;
            for (int i = 0; i < secWord.Length; i++)
            {
                sum += (int)secWord[i];
            }

            
            string temp = sum.ToString();
            int mask = -1;
            while (mask < 0)
            {
                sum = 0;
                for (int i = 0; i < temp.Length; i++)
                {
                    sum += int.Parse(temp[i].ToString());
                }
                if (sum < 10 && sum != 0)
                {
                    mask = sum;
                }
                temp = sum.ToString();
            }

            string msg = string.Empty;
            for (int i = 0; i < encrypted.Length; i++)
            {
                if (encrypted[i] % mask == 0)
                {
                    msg += (char)((int)encrypted[i] + mask);
                }
                else
                {
                    msg += (char)((int)encrypted[i] - mask);
                }
            }
            msg = new string(msg.Reverse().ToArray());
            Console.WriteLine(msg);

        }
    }
}