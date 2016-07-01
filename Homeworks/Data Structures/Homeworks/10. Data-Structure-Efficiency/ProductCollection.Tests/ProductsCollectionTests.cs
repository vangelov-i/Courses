using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProductCollection.Tests
{
    using System.Collections.Generic;
    using System.Linq;

    [TestClass]
    public class ProductCollectionTests
    {
        [TestMethod]
        public void Add_SingleProduct_CountShouldBe1()
        {
            var products = new ProductsCollection();

            products.Add(1, "magnit", "Bai Tosho", 2.5m);

            Assert.AreEqual(1, products.Count, "Count is not 1");
        }

        [TestMethod]
        public void Add_100Products_CountShouldBe100()
        {
            var products = new ProductsCollection();

            for (int i = 0; i < 100; i++)
            {
                products.Add(i, "magnit" + i, "Bai Tosho" + i, i + 2.5m);
            }

            Assert.AreEqual(100, products.Count, "Count is not 100");
        }

        [TestMethod]
        public void Add_TwoProductsWithSameId_CountShouldBe1()
        {
            var products = new ProductsCollection();

            products.Add(1, "magnit", "Bai Tosho", 2.5m);
            products.Add(1, "nov magnit", "Bai Tosho", 3.5m);

            Assert.AreEqual(1, products.Count, "Count is not 1");
        }

        [TestMethod]
        public void Add_TwoProductsWithSameId_ProductShouldBeOverriden()
        {
            var products = new ProductsCollection();

            products.Add(1, "magnit", "Bai Tosho", 2.5m);
            products.Add(1, "nov magnit", "Bai Tosho", 3.5m);

            Assert.AreEqual(1, products.Count, "Count is not 1");
        }

        [TestMethod]
        public void Remove_AddAndRemoveSingleProduct_CountShouldBe0()
        {
            var products = new ProductsCollection();

            products.Add(1, "magnit", "Bai Tosho", 2.5m);
            products.Remove(1);

            Assert.AreEqual(0, products.Count, "Count is not 0");
        }

        [TestMethod]
        public void FindSingleProductByTittle_ShouldReturnCorrectProduct()
        {
            var products = new ProductsCollection();
            var expected = new Product(1, "magnit", "Bai Tosho", 2.5m);
            products.Add(1, "magnit", "Bai Tosho", 2.5m);

            var actualProduct = products.FindProductsByTitle("magnit").First();

            Assert.AreEqual(expected, actualProduct, "Returned product is not the same.");
        }

        [TestMethod]
        public void FindProductsByTittle_AddMultipleProducts_ShouldReturnSameProductsOrderedById()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            for (int i = 99; i >= 0; i--)
            {
                string title = string.Empty;
                if (i % 5 == 0)
                {
                    title = "magnit";
                    var product = new Product(i, title, "Bai Tosho" + i, i + 2.5m);
                    expectedProducts.Add(product);
                }
                else
                {
                    title = "magnit" + i;
                }

                products.Add(i, title, "Bai Tosho" + i, i + 2.5m);
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products.FindProductsByTitle("magnit").ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestMethod]
        public void FindProductsByTittle_SearchNonExistingTitle_ShouldReturnEmptyCollection()
        {
            var products = new ProductsCollection();

            for (int i = 0; i < 100; i++)
            {
                products.Add(i, "magnit" + i, "Bai Tosho" + i, i + 2.5m);
            }

            var actualProducts = products.FindProductsByTitle("magnit").ToList();

            Assert.AreEqual(0, actualProducts.Count, "Returned products count is not 0.");
        }

        [TestMethod]
        public void FindByTitleAndPrice_AddMultipleProducts_ShouldReturnCorrectOnes()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            for (int i = 99; i >= 0; i--)
            {
                string title = string.Empty;
                decimal price = 0.0m;
                if (i % 5 == 0)
                {
                    title = "magnit";
                    price = 1.5m;
                    var product = new Product(i, title, "Bai Tosho" + i, price);
                    expectedProducts.Add(product);
                }
                else
                {
                    title = "magnit" + i;
                    price = i + 2.5m;
                }

                products.Add(i, title, "Bai Tosho" + i, price);
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products.FindProductsByTitleAndPrice("magnit", 1.5m)
                .ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestMethod]
        public void FindProductsByPriceRange_AddMultipleProducts_ShouldReturnCorrectOnes()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            decimal price = 5.0m;
            for (int i = 99; i >= 0; i--)
            {
                if (price <= 15 && i % 5 == 0)
                {
                    var product = new Product(i, "magnit", "Bai Tosho", price);
                    expectedProducts.Add(product);
                    products.Add(i, "magnit", "Bai Tosho", price);
                    price++;
                    continue;
                }

                products.Add(i, "magnit", "Bai Tosho", i + 20.5m);
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products.FindProductsByPriceRange(5, 15).ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts, "Returned products are not in the given price range.");
        }

        [TestMethod]
        public void FindByTitleAndPriceRange_AddMultipleProducts_ShouldReturnCorrectOnes()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            decimal price = 1.0m;

            for (int i = 99; i >= 0; i--)
            {
                string title = string.Empty;
                if (i % 5 == 0 && price <= 15)
                {
                    title = "magnit";
                    var product = new Product(i, title, "Bai Tosho" + i, price);
                    expectedProducts.Add(product);
                    products.Add(i, title, "Bai Tosho" + i, price);
                    price++;
                }
                else
                {
                    title = "magnit" + i;
                    products.Add(i, title, "Bai Tosho" + i, 0.5m);
                }
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products
                .FindProductsTitleAndPriceRange("magnit", 1.0m, 15.0m)
                .ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestMethod]
        public void FindProductsBySupplierAndPriceRange_AddMultipleProducts_ShouldReturnCorrectOnes()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            decimal price = 5.0m;
            for (int i = 99; i >= 0; i--)
            {
                if (price <= 15 && i % 5 == 0)
                {
                    var product = new Product(i, "magnit", "Bai Tosho", price);
                    expectedProducts.Add(product);
                    products.Add(i, "magnit", "Bai Tosho", price);
                    price++;
                    continue;
                }

                products.Add(i, "magnit", "Bai Tosho" + i, i + 20.5m);
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products
                .FindeProductsBySupplierAndPriceRange("Bai Tosho", 5, 15)
                .ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }

        [TestMethod]
        public void FindProductsBySupplierAndPrice_AddMultipleProducts_ShouldReturnCorrectOnes()
        {
            var products = new ProductsCollection();
            var expectedProducts = new List<Product>();

            decimal price = 5.0m;
            for (int i = 99; i >= 0; i--)
            {
                if (i % 5 == 0)
                {
                    var product = new Product(i, "magnit", "Bai Tosho", price);
                    expectedProducts.Add(product);
                    products.Add(i, "magnit", "Bai Tosho", price);
                    continue;
                }

                products.Add(i, "magnit", "Bai Tosho" + i, i + 20.5m);
            }

            expectedProducts = expectedProducts.OrderBy(p => p.Id).ToList();
            var actualProducts = products
                .FindProductsBySupplierAndPrice("Bai Tosho", 5)
                .ToList();

            CollectionAssert.AreEqual(expectedProducts, actualProducts);
        }
    }
}