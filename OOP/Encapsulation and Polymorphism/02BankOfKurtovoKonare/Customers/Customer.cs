using System;

namespace _02BankOfKurtovoKonare.Customers
{
    public class Customer
    {
        private readonly string type;

        public Customer(string type)
        {
            type = type.ToLower().Trim();
            if (type != "company" && type != "individual")
            {
                throw new ArgumentException("Customer type must be \"individual\" or \"company\" ");
            }

            this.type = type;
        }

        public string Type
        {
            get { return this.type; }
        }
    }
}
