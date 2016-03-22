namespace CohesionAndCoupling.Utilities
{
    using System;

    using CohesionAndCoupling.Interfaces;

    public static class MathUtilities
    {
        public static double CalculateDistance2D(I2Dimentional firstPoint2D, I2Dimentional secondPoint2D)
        {
            double distance = 
                Math.Sqrt(
                    Math.Pow(secondPoint2D.X - firstPoint2D.X, 2) + 
                    Math.Pow(secondPoint2D.Y - firstPoint2D.Y, 2));

            return distance;
        }

        public static double CalculateDistance3D(I3Dimentional firstPoint3D, I3Dimentional secondPoint3D)
        {
            double distance =
                Math.Sqrt(
                    Math.Pow(secondPoint3D.X - firstPoint3D.X, 2) + 
                    Math.Pow(secondPoint3D.Y - firstPoint3D.Y, 2)+ 
                    Math.Pow(secondPoint3D.Z - firstPoint3D.Z, 2));

            return distance;
        }

        public static double CalculateCuboidVolume(ICuboid cuboid)
        {
            double volume = cuboid.Width * cuboid.Height * cuboid.Depth;

            return volume;
        }

        public static double CalculateCuboidDiagonal(ICuboid cuboid)
        {
            double diagonal =
                Math.Sqrt(
                    Math.Pow(cuboid.Width, 2) + 
                    Math.Pow(cuboid.Height, 2) + 
                    Math.Pow(cuboid.Depth, 2));

            return diagonal;
        }

        public static double CalculateRectangleDiagonal(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentException("Rectangle's sides must be positive numbers.");
            }

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));

            return diagonal;
        }
    }
}