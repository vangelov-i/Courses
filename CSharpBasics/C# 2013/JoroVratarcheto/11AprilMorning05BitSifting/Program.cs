using System;

//17:04 - 17:40


    class Program
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());

            ulong countSieves = ulong.Parse(Console.ReadLine());

            if (countSieves > 0)
            {
                ulong[] sieves = new ulong[countSieves];
                ulong combinedSieves = 0L;
                for (ulong i = 0; i < countSieves; i++)
                {
                    sieves[i] = ulong.Parse(Console.ReadLine());
                    combinedSieves |= sieves[i];
                }

                number = number & ~(combinedSieves);
            }

            string binary = Convert.ToString((long)number, 2);

            int numOfBits1 = 0;
            foreach (var digit in binary)
            {
                if (digit == '1')
                {
                    numOfBits1++;
                }
            }
            Console.WriteLine(numOfBits1);

        }
    }
