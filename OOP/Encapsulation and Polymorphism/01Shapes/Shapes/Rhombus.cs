using System;

namespace _01Shapes.Shapes
{
    class Rhombus : BasicShape
    {
        public Rhombus(double width, double height)
            : base(width, height)
        {
        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }

        public override double CalculatePerimeter()
        {
            return 4 * this.Side();
        }

        private double Side()
        {
            return Math.Sqrt(this.Width * this.Width + this.Height * this.Height);
        }
    }
}
