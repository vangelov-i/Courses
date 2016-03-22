using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02InterestCalculator
{

    class InterestCalculator
    {
        private readonly Func<decimal, decimal, int, decimal> interestDelegate;

        private decimal money;

        private decimal interest;

        private int years;

        public InterestCalculator(decimal money, decimal interest, int years, Func<decimal, decimal, int, decimal> func)
        {
            this.Money = money;
            this.Interest = interest;
            this.Years = years;
            this.interestDelegate = func;
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                this.money = value;
            }
        }

        public decimal Interest
        {
            get { return this.interest; }
            set
            {
                this.Validation(value, "Interest");

                this.interest = value;
            }
        }

        public int Years
        {
            get { return this.years; }
            set
            {
                this.Validation(value, "Years");

                this.years = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0:F4}", this.interestDelegate(this.Money, this.Interest, this.Years));
        }


        private void Validation(decimal value, string type)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(string.Format("{0} cannot be a negative number.", type));
            }
        }
    }
}
