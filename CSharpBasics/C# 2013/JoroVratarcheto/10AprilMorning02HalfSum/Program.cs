using System;

namespace _10AprilMorning02HalfSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstSeq = new int[n];
            int[] secondSeq = new int[n];
            int sumFirst = 0;
            int sumSecond = 0;
            for (int i = 0, j= 0; i < 2*n; i++)
            {
                if (i < n)
                {
                    firstSeq[i] = int.Parse(Console.ReadLine());
                    sumFirst += firstSeq[i];
                }
                else
                {
                    secondSeq[j] = int.Parse(Console.ReadLine());
                    sumSecond += secondSeq[j];
                    j++;
                }
            }

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Yes, sum={0}", sumFirst);
            }
            else
            {
                Console.WriteLine("No, diff={0}",Math.Abs(sumFirst - sumSecond));
            }
        }
    }
}
