namespace CohesionAndCoupling.Models
{
    using CohesionAndCoupling.Interfaces;

    public class Point3D : Point2D, I3Dimentional
    {
        public Point3D(double x, double y, double z)
            : base(x, y)
        {
            this.Z = z;
        }

        public double Z { get; set; }
    }
}