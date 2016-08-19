using System;
using System.Linq;

// 20:30 - 21:30

namespace _14AprilMorning02BiggestTriple
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            string[] numbers = strInput.Split(' ');
            int NumOfTriples = numbers.Length / 3;
            int reminder = numbers.Length % 3;
            //Console.WriteLine(NumOfTriples);
            //Console.WriteLine(reminder);

            // last triple sum
            if (numbers.Length > 2)
            {
                int lastTripleSum = 0;
                if (reminder == 1)
                {
                    lastTripleSum = int.Parse(numbers[numbers.Length - 1]);
                }
                else if (reminder == 2)
                {
                    lastTripleSum = int.Parse(numbers[numbers.Length - 1]) +
                                    int.Parse(numbers[numbers.Length - 2]);
                }

                int[] arrayTriples = new int[NumOfTriples];
                for (int i = 0, j = 0; i < arrayTriples.Length; i++, j += 3)
                {
                    arrayTriples[i] = int.Parse(numbers[j]) + int.Parse(numbers[j + 1]) + int.Parse(numbers[j + 2]);
                }

                // Dobaveno sled proverka na greshen 14-ti test/////
                int tripleMaxSum = 0;
                if (lastTripleSum != 0)
                {
                    tripleMaxSum = Math.Max(arrayTriples.Max(), lastTripleSum);
                }
                else
                {
                    tripleMaxSum = arrayTriples.Max();
                }
                ////////////////////////////////////////////////////
                int tempTripleSum = 0;
                for (int i = 0, j = 0; i < NumOfTriples; i++, j += 3)
                {
                    int firstMember = int.Parse(numbers[j]);
                    int secondMember = int.Parse(numbers[j + 1]);
                    int thirdMember = int.Parse(numbers[j + 2]);
                    tempTripleSum = firstMember + secondMember + thirdMember;
                    if (tempTripleSum == tripleMaxSum)
                    {
                        Console.WriteLine("{0} {1} {2}", firstMember, secondMember, thirdMember);
                        break;
                    }
                    else if (reminder == 2 && i == NumOfTriples - 1)  //&& i == NumOfTriples -1  => dobaveno sled kato sym poglednal koi testove sa greshni
                    {
                        Console.WriteLine("{0} {1}", numbers[numbers.Length - 2], numbers[numbers.Length - 1]);
                    }
                    else if (reminder == 1 && i == NumOfTriples - 1)  //&& i == NumOfTriples -1  => dobaveno sled kato sym poglednal koi testove sa greshni
                    {
                        Console.WriteLine(numbers[numbers.Length - 1]);
                    }

                }
            }
            else
            {
                Console.WriteLine(strInput);
            }
        }
    }
}
