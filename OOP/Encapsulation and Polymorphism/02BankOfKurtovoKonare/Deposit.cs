using System;

namespace _02BankOfKurtovoKonare
{
    using Customers;
    using Interfaces;
    public class Deposit : Account, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal iRate)
            : base(customer, balance, iRate)
        {
            this.Balance = balance;
        }


        public override decimal Balance
        {
            get
            {
                return base.Balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Deposit account cannot have negative balance when created.");
                }
                base.Balance = value;
            }
        }


    }
}
