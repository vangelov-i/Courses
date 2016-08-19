using System;

namespace _12ZeroSubset_3rd
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 integer numbers by pressing ENTER after each one of them.");
            int[] array = new int[5];
            int checker = 0;
            for (int i = 0; i < 5; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The subsets of these numbers whose sum is 0 are:");

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", array[i], array[j]);
                        checker = 1;
                    }
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", array[i], array[j], array[k]);
                            checker = 1;
                        }
                        for (int l = k + 1; l < array.Length; l++)
                        {
                            if (array[i] + array[j] + array[k] + array[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", array[i], array[j], array[k], array[l]);
                                checker = 1;
                            }
                        }
                    }
                }

            }
            if (checker == 0)
            {
                Console.WriteLine("no zero subset");
            }

        }
    }
}
