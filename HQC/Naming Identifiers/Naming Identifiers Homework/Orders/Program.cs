// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Orders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    using Orders.Models;

    public class Program
    {
        private static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DataMapper dataMapper = new DataMapper();
            IEnumerable<Category> categories = dataMapper.GetAllCategories();
            IEnumerable<Product> products = dataMapper.GetAllProducts();
            IEnumerable<Order> orders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            var top5MostExpensiveProducts = products.OrderByDescending(p => p.UnitPrice).Take(5).Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, top5MostExpensiveProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each Category
            var productsCountByCategory =
                products.GroupBy(p => p.CategoryId)
                    .Select(grp => new { Category = categories.First(c => c.Id == grp.Key).Name, Count = grp.Count() })
                    .ToList();
            foreach (var item in productsCountByCategory)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var top5MostOrderedProducts =
                orders.GroupBy(o => o.ProductId)
                    .Select(
                        grp =>
                        new
                            {
                                Product = products.First(p => p.Id == grp.Key).Name, 
                                Quantities = grp.Sum(grpgrp => grpgrp.Quantity)
                            })
                    .OrderByDescending(q => q.Quantities)
                    .Take(5);
            foreach (var item in top5MostOrderedProducts)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable Category
            var mostProfitableCategory =
                orders.GroupBy(o => o.ProductId)
                    .Select(
                        g =>
                        new
                            {
                                catId = products.First(p => p.Id == g.Key).CategoryId, 
                                price = products.First(p => p.Id == g.Key).UnitPrice, 
                                quantity = g.Sum(p => p.Quantity)
                            })
                    .GroupBy(gg => gg.catId)
                    .Select(
                        grp =>
                        new
                            {
                                category_name = categories.First(c => c.Id == grp.Key).Name, 
                                total_quantity = grp.Sum(g => g.quantity * g.price)
                            })
                    .OrderByDescending(g => g.total_quantity)
                    .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.category_name, mostProfitableCategory.total_quantity);
        }
    }
}