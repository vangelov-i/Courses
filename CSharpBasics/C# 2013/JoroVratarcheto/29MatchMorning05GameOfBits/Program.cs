using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 18:53 - 19:46  -> s bitwise ->  pochti nikyv uspeh!  /// +10 min sys string -> 62/100 
// 22:08 - 22:30  -> bitwise  -> 100 !! (total 1:20 min)
class Program
{
    static void Main(string[] args)
    {
        checked
        {
            uint number = uint.Parse(Console.ReadLine());

            uint mask = 0;
            uint temp = 0;

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Odd")
                {
                    string binary = Convert.ToString(number, 2);
                    temp = 0;
                    string test = string.Empty;
                    for (int i = 0; i < binary.Length; i += 2)
                    {
                        mask = 1 & number;
                        temp = temp | (mask << i/2);
                        number = number >> 2;
                    }

                }
                else if (command == "Even")
                {
                    string binary = Convert.ToString(number, 2);
                    temp = 0;
                    number = number >> 1;
                    for (int i = 0; i < binary.Length; i += 2)
                    {
                        mask = 1 & number;
                        temp = temp | (mask << i / 2);
                        number = number >> 2;
                    }
                }
                else
                {
                    break;
                }
                number = temp;
            }

            string countOnes = Convert.ToString(number, 2);
            int counter = 0;
            for (int i = 0; i < countOnes.Length; i++)
            {
                if (countOnes[i] == '1')
                {
                    counter++;
                }
            }
            Console.WriteLine("{0} -> {1}", number, counter);

        }
    }
}