using System;

namespace _02BankOfKurtovoKonare
{
    using Customers;
    public class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal iRate)
            : base (customer, balance, iRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative number.");
            }

            if (this.Customer.Type == "individual")
            {
                // first 3 months for individual loans are interest free
                months -= 3;
            }
            else
            {
                // first 2 months for company loans are interest free
                months -= 2;
            }
            if (months <= 0)
            {
                return this.Balance;
            }
            return this.Balance * (1 + this.IRate * months);
        }

    }
}
