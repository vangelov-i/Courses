using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 18:15 - 20:15  // 68 tochki ot pyrvo puskane

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());

        int positionsOfBits = n * 8 - 2;
        int timesStepWillBeAplied = (n * 8 - 2) / step;
        int bitToCopy = positionsOfBits - timesStepWillBeAplied * step;

        bool checker = true;

        string pulledBits = string.Empty;
        int temp = 0;
        int number = 0;
        int reminder = 6;
        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());
            temp = number;
            if (reminder < 0 && checker)
            {
                reminder = 8 + reminder;
                continue;
            }
            else if (reminder < 0 && !checker)
            {
                reminder = 8 + reminder;
            }
            number = (number >> reminder) & 1;
            pulledBits += number;
            if (reminder - step >= 0)
            {
                reminder = reminder - step;
                while (reminder >=0)
                {
                    number = temp;
                    number = (number >> reminder) & 1;
                    pulledBits += number;
                    reminder = reminder - step;
                }
                checker = false;
            }
            else
            {
                reminder = (reminder + 8) - step;
                checker = true;
            }
        }

        int numBytes = pulledBits.Length / 8;
        int remindingBits = pulledBits.Length % 8;

        List<string> outputBytes = new List<string>();
        string temp1 = string.Empty;
        for (int i = 0; i < numBytes*8; i++)
        {
            temp1 += pulledBits[i];
            if (i % 7 == 0 && i != 0)
            {
                outputBytes.Add(temp1);
                temp1 = string.Empty;
            }
        }
        if (pulledBits.Length > 8)
        {
            temp1 = string.Empty;
            for (int i = pulledBits.Length - remindingBits; i < pulledBits.Length; i++)
            {
                temp1 += pulledBits[i];
            }
            temp1 = temp1.PadRight(8, '0');
            outputBytes.Add(temp1);

            foreach (var str in outputBytes)
            {
                Console.WriteLine(Convert.ToInt32(str, 2));
            }
        }
        else
        {
            Console.WriteLine(Convert.ToInt32(pulledBits.PadRight(8, '0'), 2));
        }

    }
}
//      1 1 110000 1111 0 000   1111000 0  11110000