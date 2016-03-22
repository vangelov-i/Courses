namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                this.ValidateSide(value, "Radius");

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = Math.PI * 2 * this.Radius;

            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * Math.Pow(this.Radius, 2);

            return surface;
        }
    }
}