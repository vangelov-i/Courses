namespace CohesionAndCoupling.Models
{
    using System;

    using CohesionAndCoupling.Interfaces;

    public class Cuboid : ICuboid
    {
        private double depth;

        private double height;

        private double width;

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.ValidateSide(value, nameof(this.Width));

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.ValidateSide(value, nameof(this.Height));

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                this.ValidateSide(value, nameof(this.Depth));

                this.depth = value;
            }
        }

        private void ValidateSide(double side, string parameterName)
        {
            if (side <= 0)
            {
                throw new ArgumentException(parameterName, "Value must be positive number.");
            }
        }
    }
}