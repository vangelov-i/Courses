using System;

namespace _01Shapes.Shapes
{
    using Interfaces;
    public class Circle : IShape
    {
        private const double PI = 3.14159265358979;
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius cannot be negative number.");
                }
                this.radius = value;
            }
        }
        public double CalculateArea()
        {
            return PI * this.Radius * this.Radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * PI * this.Radius;
        }
    }
}
