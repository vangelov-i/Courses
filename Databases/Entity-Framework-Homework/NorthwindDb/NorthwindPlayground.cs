namespace NorthwindDb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main(string[] args)
        {
            // TASK 2
            var customerToAdd = new Customer()
            {
                CustomerID = "ASD",
                CompanyName = "EF-Company"
            };

            //CustomersManager.AddCustomer(customerToAdd);
            //CustomersManager.EditCustomerCompanyName("ASD", "NovoIme");
            //CustomersManager.DeleteCustomer("ASD");

            //// TASK 3
            //var customersShippedOrdersToCanadaIn1997 = CustomersManager.GetCustomersByShippmentDateAndCountry(
            //    "Canada",
            //    new DateTime(1997, 1, 1));

            //PrintCustomers(customersShippedOrdersToCanadaIn1997);

            //// TASK 4
            //customersShippedOrdersToCanadaIn1997 = CustomersManager
            //    .GetCustomersByShippmentDateAndCountryNative(
            //    "Canada",
            //    new DateTime(1997, 1, 1));

            //PrintCustomers(customersShippedOrdersToCanadaIn1997);

            // TASK 5
            var startDate = new DateTime(1997, 01, 01);
            var endtDate = new DateTime(1997, 04, 30);
            string region = "WA";
            var salesInWAInFirstQuarter1997 = GetSalesByRegionAndDateRange(
                startDate, 
                endtDate, 
                region);

            PrintOrders(salesInWAInFirstQuarter1997);

            // TASK 6
            
        }

        private static IEnumerable<Order> GetSalesByRegionAndDateRange(
            DateTime startDate, 
            DateTime endtDate, 
            string region)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var result =
                    dbContext.Orders
                    .Where(o => o.OrderDate >= startDate && o.OrderDate <= endtDate)
                    .Where(o => o.ShipRegion == region)
                    .ToList();

                return result;
            }
        }

        private static void PrintOrders(IEnumerable<Order> orders)
        {
            foreach (var order in orders)
            {
                Console.WriteLine(
                    "Order ID: {0}{1}Region: {2}", 
                    order.OrderID, 
                    Environment.NewLine,
                    order.ShipRegion);
            }
        }

        private static void PrintCustomers(
            IEnumerable<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(
                    "{0} {1}",
                    customer.CustomerID,
                    customer.ContactName);
            }
        }
    }
}