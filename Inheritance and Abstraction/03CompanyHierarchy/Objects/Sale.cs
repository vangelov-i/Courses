using System;

namespace _03CompanyHierarchy.Objects
{
    public class Sale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public string ProductName 
        {
            get { return this.productName; }
            set {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Product name can not be null or empty.");
                }
                this.productName = value; }
        }

        public DateTime Date 
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public decimal Price 
        {
            get { return this.price; }
            set {
                if (value < 0)
                {
                    throw new IndexOutOfRangeException("Price can not be negative number.");
                }
                this.price = value; }
        }


    }
}
