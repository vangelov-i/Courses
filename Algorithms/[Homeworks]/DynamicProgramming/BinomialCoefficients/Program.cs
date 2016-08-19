namespace BinomialCoefficients
{
    using System;

    class Program
    {
        private static int[][] binomials;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            binomials = new int[n + 1][];
            binomials[n] = new int[k + 1];

            Console.WriteLine(FindBinomial(n, k));
            Console.WriteLine();
        }

        private static int FindBinomial(int n, int k)
        {
            if (k == 0 || k == n)
            {
                return 1;
            }

            binomials[n-1] = new int[k + 1];

            if (binomials[n][k] != 0)
            {
                return binomials[n][k];
            }

            binomials[n][k] = FindBinomial(n - 1, k) + FindBinomial(n - 1, k - 1);
            return binomials[n][k];
        }

    }
}
