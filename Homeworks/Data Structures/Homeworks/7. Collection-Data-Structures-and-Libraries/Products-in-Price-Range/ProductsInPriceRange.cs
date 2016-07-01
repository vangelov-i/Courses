using System;
using System.Linq;

using Wintellect.PowerCollections;

class ProductsInPriceRange
{
    static void Main()
    {
        var productsPrices = new OrderedMultiDictionary<decimal, string>(false);
        int productsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < productsCount; i++)
        {
            string[] productParams = Console.ReadLine().Split();
            string productType = productParams[0];
            decimal productPrice = decimal.Parse(productParams[1]);
            productsPrices.Add(productPrice, productType);
        }

        decimal[] priceRangeParams = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        decimal mintPrice = priceRangeParams[0];
        decimal maxPrice = priceRangeParams[1];

        foreach (var priceProductsPair in productsPrices.Range(mintPrice, true, maxPrice, true))
        {
            foreach (string product in priceProductsPair.Value)
            {
                Console.WriteLine("{0} {1}", priceProductsPair.Key, product);
            }
        }
    }
}