using System;

namespace _02BankOfKurtovoKonare
{
    using Customers;
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal iRate)
            : base (customer,balance,iRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            decimal HalfPriceAmount = 0;

            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months cannot be negative number.");
            }

            if (this.Customer.Type == "company")
            {
                HalfPriceAmount = this.Balance - this.Balance * (1 + (this.IRate / 2) * 12);
                months -= 12;
            }
            else
            {
                HalfPriceAmount = this.Balance - this.Balance * (1 + (this.IRate / 2) * 6);
                months -= 6;
            }
            if (months <= 0)
            {
                return this.Balance;
            }
            return this.Balance * (1 + this.IRate * months) - HalfPriceAmount;
        }


    }
}
