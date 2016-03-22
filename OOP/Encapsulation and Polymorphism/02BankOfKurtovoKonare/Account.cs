using System;

namespace _02BankOfKurtovoKonare
{
    using Customers;
    using Interfaces;
    public abstract class Account : IInterest, IDepositable
    {
        private Customer customer;
        private decimal balance;
        private decimal iRate;

        public Account(Customer customer, decimal balance, decimal iRate)
        {
            this.customer = customer;
            this.Balance = balance;
            this.IRate = iRate;
        }

        public Customer Customer 
        {
            get { return this.customer; }
        }

        public virtual decimal Balance 
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal IRate 
        {
            get { return this.iRate; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative number.");
                }
                this.iRate = value; }
        }



        public virtual decimal CalculateInterest(int months)
        {
            if (months < 0)
            {
                throw new ArgumentOutOfRangeException("Months","Months cannot be negative number.");
            }
            return this.Balance * (1 + this.IRate * months);
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Deposit amount cannot be a negative number.");
            }
            this.Balance += amount;
        }


        public virtual void Withdraw(decimal amount)
        {
            if (this.Balance <= 0)
            {
                throw new ArgumentException("Only deposit accounts are allowed to withdraw funds.");
            }

            if (this.Balance - amount < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format(
                    "The maximum amount you can withdraw is {0:F2}"
                   , this.Balance));
            }

            this.Balance -= amount;
        }


        public override string ToString()
        {
            return string.Format("Customer type: {0}\n" + "Balance: {1:F2}\n" +
                "Interest rate: {2:F1}%", this.Customer.Type, this.Balance, (this.IRate * 100));
        }

    }
}
