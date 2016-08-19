using System;

namespace _08CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            double n = 0;
            double nX2 = n * 2;
            double nPlus1 = n + 1;
            double nFac = 1;
            double nX2Fac = 1;
            double nPlus1Fac = 1;

            for (int i = 1; i <= nX2 ; i++)
            {
                if (i <= n)
                {
                    nFac *= i;
                }
                nX2Fac *= i;
                if (i <= n + 1)
                {
                    nPlus1Fac *= i;
                }
            }
            Console.WriteLine("Cn = {0}", nX2Fac / (nPlus1Fac*nFac));
        }
    }
}
