using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:20 - 17:00  100 tochki
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());

            int temp1 = 0;
            List<int> numList = new List<int>();
            for (int i = 0; i < n; i++)
            {
                temp1 = int.Parse(Console.ReadLine());
                numList.Add(temp1);
            }
            int lastN = int.Parse(Console.ReadLine());

            int temp = 0;
            int currBit = -1;
            int counter = 0;
            string binary = string.Empty;
            int numBits = 0;
            for (int i = 0; i < n; i++)
            {
                temp = numList[i];
                binary = Convert.ToString(temp, 2);
                //Console.WriteLine(binary);
                numBits = binary.Length;
                //Console.WriteLine(numBits);
                int[] bitsToChange = new int[numBits];
                for (int j = 0, j1 = 0; j < numBits; j++, j1+=2)
                {
                    bitsToChange[j] = j1;
                    //Console.WriteLine(bitsToChange[j]);
                }
                //Console.WriteLine(temp);
                for (int k = 0; k < bitsToChange.Length; k++)
                {
                    //Console.WriteLine(Convert.ToString(temp, 2))
                    currBit = (lastN >> bitsToChange[k]) & 1;
                    if (currBit == 0)
                    {
                        counter++;
                    }
                    lastN = lastN | (1 << bitsToChange[k]);
                }
            }
            Console.WriteLine(lastN);
            Console.WriteLine(counter);
        }
    }
}