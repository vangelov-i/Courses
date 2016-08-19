using System;

namespace _10OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Please tell us how many integers you will enter: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Please enter your numbers by pressing ENTER after each of them: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < array.Length; i += 2)
            {
                productOdd *= array[i];
            }

            for (int i = 1; i < array.Length; i += 2)
            {
                productEven *= array[i];
            }
            bool isEqual = productOdd == productEven;
            if (isEqual)
            {
                Console.WriteLine("Yes. Product = {0}", productEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("odd_product = {0}", productOdd);
                Console.WriteLine("even_product = {0}", productEven);
            }
        }
    }
}
