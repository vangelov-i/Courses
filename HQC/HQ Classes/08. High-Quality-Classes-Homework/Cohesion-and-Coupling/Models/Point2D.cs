namespace CohesionAndCoupling.Models
{
    using CohesionAndCoupling.Interfaces;

    public class Point2D : I2Dimentional
    {
        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}