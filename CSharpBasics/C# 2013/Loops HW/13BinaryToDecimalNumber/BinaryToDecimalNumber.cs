using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main()
        {
            string binary = Console.ReadLine();
            int arrayMembers = 0;
            foreach (var item in binary)
            {
                arrayMembers++;
            }
            long[] binaryLongArray = new long[arrayMembers];

            int index = 0;
            foreach (var item in binary)
            {
                if (item == '0')
                {
                    binaryLongArray[index] = 0;
                }
                else
                {
                    binaryLongArray[index] = 1;
                }
                index++;
            }

            long sum = 0;
            for (int i = 0; i < binaryLongArray.Length; i++)
            {
                if (binaryLongArray[i] == 1)
                {
                    sum += (long)Math.Pow(2, (arrayMembers -1)); 
                }
                arrayMembers--;
            }
            Console.WriteLine(sum);
        }
    }
}
