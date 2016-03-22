using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;


        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.Validate(value, "Numerator");

                this.numerator = value;
            }
        }

        public long Denominator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                this.Validate(value, "Denominator");

                this.denominator = value;
            }
        }


        public static Fraction operator +(Fraction firstFrac, Fraction secFrac)
        {
            long numerator = firstFrac.Numerator * secFrac.Denominator + secFrac.Numerator * firstFrac.Denominator;
            long denominator = firstFrac.Denominator * secFrac.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            return result;
        }


        public static Fraction operator -(Fraction firstFrac, Fraction secFrac)
        {
            long numerator = firstFrac.Numerator * secFrac.Denominator - secFrac.Numerator * firstFrac.Denominator;
            long denominator = firstFrac.Denominator * secFrac.Denominator;
            Fraction result = new Fraction(numerator, denominator);
            return result;
        }
        


        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;
            //return "" + this.Numerator + "\n" + this.Denominator + "\n" + result;
            return "" + result;
        }


        private void Validate(long number, string param)
        {
            if (number == 0)
            {
                throw new InvalidOperationException(string.Format("{0} cannot be cannot be 0.", param));
            }

        }

    }
}
