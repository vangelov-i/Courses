using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 10:25 - 
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            string[] strNums = Console.ReadLine().Split(' ');

            int[] numbers = new int[strNums.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(strNums[i]);
            }

            string command = string.Empty;
            while (true)
            {

                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                else if (Char.IsDigit(command[0])) // command: [row] [direction] [rotation]
                {
                    string[] partsComand = command.Split(' ');
                    if (partsComand[1] == "right")
                    {
                        int row = int.Parse(partsComand[0]);
                        int rotations = int.Parse(partsComand[2]) % 12;
                        int mask = (int)Math.Pow(2, rotations) - 1;
                        mask = numbers[row] & mask;
                        mask = mask << (12 - rotations);
                        numbers[row] = (numbers[row] >> rotations) | mask;
                    }
                    else
                    {
                        int row = int.Parse(partsComand[0]);
                        int rotations = int.Parse(partsComand[2]) % 12;
                        int mask = (int)Math.Pow(2, rotations) - 1;
                        mask = numbers[row] >> (12 - rotations) & mask;
                        numbers[row] = (numbers[row] << rotations) | mask;
                        numbers[row] = numbers[row] & 4095;

                    }
                }
                else                              //command: check [col]
                {
                    string[] value = command.Split(' ');
                    int bitPos = int.Parse(value[1]);
                    int bitCheck = -1;
                    int bitsOf1 = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        bitCheck = (numbers[i] >> bitPos) & 1;
                        if (bitCheck == 1)
                        {
                            bitsOf1++;
                        }
                    }
                    Console.WriteLine(bitsOf1);
                }

            }
            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();


        }
    }
}