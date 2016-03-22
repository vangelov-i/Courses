using System;

//  Write a method ReadNumber(int start, int end) that enters an integer 
//  number in given range [start…end]. If an invalid number or non-number 
//  text is entered, the method should throw an exception. Using this 
//  method write a program that enters 10 numbers: a1, a2, … a10, 
//  such that 1 < a1 < … < a10 < 100. If the user enters an invalid number, 
//  let the user to enter again.

namespace _02EnterNumbers
{
    class Numbers
    {
        private const int Count = 10;
        private static int[] tenNums = new int[Count];
        private const int start = -200;
        private const int end = 200;
        private const int NumsStart = 1;
        private const int NumsEnd = 100;

        static void Main()
        {
            try
            {
                for (int i = 0, j = 0; i < Count; )
                {
                    j = ReadNumber(start, end);
                    if (j > NumsStart && j < NumsEnd)
                    {
                        if (i != 0 && j > tenNums[i - 1])
                        {
                            if (NumsEnd - j - (Count - i) < 0)
                            {
                                Console.WriteLine("The current number can not be bigger than {0}", NumsEnd - (Count - i));
                            }
                            else
                            {
                                tenNums[i] = j;
                                i++;
                            }
                        }
                        else if (i == 0)
                        {
                            if (NumsEnd - j - (Count - i) < 0)
                            {
                                Console.WriteLine("The current number can not be bigger than {0}", NumsEnd - Count);
                            }
                            else
                            {
                                tenNums[i] = j;
                                i++;
                            }
                        }
                    }
                }

                foreach (int num in tenNums)
                {
                    Console.WriteLine(num);
                }
            }
            catch (IndexOutOfRangeException iore)
            {
                Console.WriteLine(iore.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
        }

        static int ReadNumber(int start, int end)
        {
            
            try
            {
                Console.Write("Please enter an integer number in the range {0} < number < {1} : ", start, end);
                int temp = int.Parse(Console.ReadLine());
                if (temp < start || temp > end)
                {
                    throw new IndexOutOfRangeException
                        (
                        string.Format("Your number must be in the range {0} < number < {1}", start, end)
                        );
                }
                return temp;
            }
            catch (OverflowException)
            {
                throw new OverflowException
                        (
                        string.Format("Your number must be in the range {0} < number < {1}", start, end)
                        );
            }
            catch (FormatException)
            {
                throw new FormatException("The input is not a number");
            }
        }
    }
}
