namespace NorthwindDb
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CustomersManager
    {
        public static void AddCustomer(Customer customer)
        {
            using (var dbContext = new NorthwindEntities())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }

        public static void EditCustomerCompanyName(
            string customerId, 
            string newCompany)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var customerToEdit = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);

                customerToEdit.CompanyName = newCompany;

                dbContext.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerId)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var customerToRemove = dbContext.Customers.FirstOrDefault(c => c.CustomerID == customerId);

                dbContext.Customers.Remove(customerToRemove);
                dbContext.SaveChanges();
            }
        }

        public static IEnumerable<Customer> GetCustomersByShippmentDateAndCountry(string country, DateTime datetime)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var result = dbContext.Customers
                    .Join(
                    dbContext.Orders
                        .Where(o => o.OrderDate.Value.Year == datetime.Year)
                        .Where(o => o.ShipCountry == country),
                    c => c.CustomerID,
                    o => o.CustomerID,
                    (c, o) => c);

                return result.ToList();
            }
        }

        public static IEnumerable<Customer> GetCustomersByShippmentDateAndCountryNative(
            string country,
            DateTime datetime)
        {
            using (var dbContext = new NorthwindEntities())
            {
                string quotedCountry = "'" + country + "'";
                string query =
                    "SELECT c.CustomerID " +
                    "FROM Customers c " +
                    "JOIN Orders o " +
                    "ON c.CustomerID = o.CustomerID " +
                    "WHERE o.ShipCountry = {0} " + 
                    "AND " +
                    "o.OrderDate  BETWEEN '01/01/{1}' AND '12/31/{1}'";

                string formatedQuery = string.Format(
                    query,
                    quotedCountry, 
                    datetime.Year);

                // TODO: There must be a way smarter way for doing this!
                var resultCustomersIds = dbContext.Database.SqlQuery<string>(formatedQuery);

                foreach (var customerId in resultCustomersIds)
                {
                    var currentCustomer = dbContext.Customers.Find(customerId);
                    yield return currentCustomer;
                }
            }
        } 
    }
}