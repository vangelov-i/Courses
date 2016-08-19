using System;
using System.Collections.Generic;

class ProductsCollectionPlayground
{
    public static void Main()
    {
        var expected = new Product(1, "magnit", "Bai Tosho", 2.5m);
        var actual = new Product(1, "magnit", "Bai Tosho", 2.5m);

        Console.WriteLine(expected.Equals(actual));
    }
}