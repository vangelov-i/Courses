using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//16:37 - 17:10 -> 100
class Program
{
    static void Main(string[] args)
    {
        checked
        {

            int n = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            d++;
            int counter = 0;
            for (int i1 = 1; i1 <= n; i1++)
            {
                for (int j1 = 1; j1 <= n; j1++)
                {
                    for (int i2 = 1; i2 <= n; i2++)
                    {
                        for (int j2 = 1; j2 <= n; j2++)
                        {
                            if (i2 == i1 && (j2 == j1 + d || j2 == j1 - d))
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)(i1 + 96), j1, (char)(i2 + 96), j2);
                                counter++;
                            }
                            else if (j1 == j2 && (i2 == i1 +d || i2 == i1 - d))
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)(i1 + 96), j1, (char)(i2 + 96), j2);
                                counter++;
                            }
                            else if (i2 == i1 + d && (j2 == j1 + d || j2 == j1 - d))
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)(i1 + 96), j1, (char)(i2 + 96), j2);
                                counter++;
                            }
                            else if (i2 == i1 - d && (j2 == j1 + d || j2 == j1 - d))
                            {
                                Console.WriteLine("{0}{1} - {2}{3}", (char)(i1 + 96), j1, (char)(i2 + 96), j2);
                                counter++;
                            }
                        }
                    }
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("No valid positions");
            }

        }
    }
}