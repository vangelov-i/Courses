using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// za 25 min - 90 tochki !
class Program
{
    static void Main(string[] args)
    {
        checked
        {


            string n = Console.ReadLine();
            int sumN = int.Parse(n[0].ToString()) + int.Parse(n[1].ToString()) + int.Parse(n[2].ToString()) + int.Parse(n[3].ToString());
            string temp = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                for (int i1 = 0; i1 < 6; i1++)
                {
                    for (int i2 = 0; i2 < 6; i2++)
                    {
                        for (int i3 = 0; i3 < 6; i3++)
                        {
                            for (int i4 = 0; i4 < 6; i4++)
                            {
                                for (int i5 = 0; i5 < 6; i5++)
                                {
                                    if (i * i1 * i2 * i3 * i4 * i5 == sumN)
                                    {
                                        temp = i.ToString() + i1 + i2 + i3 + i4 + i5;
                                        for (int j = 0; j < 6; j++)
                                        {

                                            if (temp[j].ToString() == "0")
                                            {
                                                Console.Write("-----|");
                                            }
                                            else if (temp[j].ToString() == "1")
                                            {
                                                Console.Write(".----|");
                                            }
                                            else if (temp[j].ToString() == "2")
                                            {
                                                Console.Write("..---|");
                                            }
                                            else if (temp[j].ToString() == "3")
                                            {
                                                Console.Write("...--|");
                                            }
                                            else if (temp[j].ToString() == "4")
                                            {
                                                Console.Write("....-|");
                                            }
                                            else if (temp[j].ToString() == "5")
                                            {
                                                Console.Write(".....|");
                                            }


                                        }
                                        Console.WriteLine();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (temp == "")
            {
                Console.WriteLine("No");
            }

        }
    }
}
