using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 16:05 - 16:15  100
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            string seq = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            int counter = -1;
            string output = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                for (int i1 = 0; i1 < 5; i1++)
                {
                    for (int i2 = 0; i2 < 5; i2++)
                    {
                        for (int i3 = 0; i3 < 5; i3++)
                        {
                            for (int i4 = 0; i4 < 5; i4++)
                            {
                                counter++;
                                if (counter == n)
                                {
                                    output = string.Concat(seq[i], seq[i1], seq[i2], seq[i3], seq[i4]);
                                    Console.WriteLine(output);
                                    return;
                                }
                            }
                        }
                    }
                }
            }

            if (output == string.Empty)
            {
                Console.WriteLine("No");
            }

        }
    }
}
