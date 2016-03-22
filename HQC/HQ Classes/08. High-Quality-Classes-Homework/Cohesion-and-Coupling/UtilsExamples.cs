namespace CohesionAndCoupling
{
    using System;

    using CohesionAndCoupling.Interfaces;
    using CohesionAndCoupling.Models;
    using CohesionAndCoupling.Utilities;

    public static class UtilsExamples
    {
        private static void Main()
        {
            // Throws Exception correctly
            //Console.WriteLine(FileUtilities.GetFileExtension("example"));

            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            I2Dimentional firstPoint2D = new Point2D(1, -2);
            I2Dimentional secondPoint2D = new Point2D(3, 4);
            Console.WriteLine(
                "Distance in the 2D space = {0:f2}", 
                MathUtilities.CalculateDistance2D(firstPoint2D, secondPoint2D));

            I3Dimentional firstPoint3D = new Point3D(5, 2, -1);
            I3Dimentional secondPoint3D = new Point3D(3, -6, 4);
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}", 
                MathUtilities.CalculateDistance3D(firstPoint3D, secondPoint3D));

            ICuboid cuboid = new Cuboid(3,4,5);
            Console.WriteLine(
                "Volume = {0:f2}", 
                MathUtilities.CalculateCuboidVolume(cuboid));

            Console.WriteLine(
                "Diagonal XYZ = {0:f2}",
                MathUtilities.CalculateCuboidDiagonal(cuboid));

            I3Dimentional thirdPoint3D = new Point3D(3, 4, 5);
            Console.WriteLine(
                "Diagonal XY = {0:f2}",
                MathUtilities.CalculateRectangleDiagonal(thirdPoint3D.X, thirdPoint3D.Y));

            Console.WriteLine(
                "Diagonal XZ = {0:f2}",
                MathUtilities.CalculateRectangleDiagonal(thirdPoint3D.X, thirdPoint3D.Z));

            Console.WriteLine(
                "Diagonal YZ = {0:f2}",
                MathUtilities.CalculateRectangleDiagonal(thirdPoint3D.Y, thirdPoint3D.Z));
        }
    }
}