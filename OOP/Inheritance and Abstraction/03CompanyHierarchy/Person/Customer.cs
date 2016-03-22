using System;

namespace _03CompanyHierarchy.Person
{
    public class Customer : Person
    {
        private decimal balance;

        public Customer(int id, string firstName, string lastName, decimal balance)
            : base(id, firstName, lastName)
        {
            this.Balance = balance;
        }


        public decimal Balance 
        {
            get { return this.balance; }
            set{
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance cannot be a negative number.");
                }
                this.balance = value;
            }
        }

    }
}
