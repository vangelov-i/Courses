namespace _03CompanyHierarchy.Person
{
    using System.Collections.Generic;

    using _03CompanyHierarchy.Objects;

    public class SalesEmployee : RegularEmployee
    {
        private readonly List<Sale> Sales = new List<Sale>();

        public SalesEmployee(int id, string firstName, string lastName, decimal salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
        }

        public void AddSale(Sale sale)
        {
            this.Sales.Add(sale);
        }

        // THIS IS OPTIONAL
        public override string ToString()
        {
            string salesList = string.Empty;
            foreach (var item in this.Sales)
            {
                salesList += "\nProduct name: " + item.ProductName + "\nDate of sale: " + item.Date.ToShortDateString()
                             + "\nPrice: " + item.Price;
            }

            return base.ToString() + "Sales employy's list of sales:" + salesList;
        }
    }
}