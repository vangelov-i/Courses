namespace Abstraction
{
    using System;

    public abstract class Figure
    {

        public abstract double CalculatePerimeter();
        
        public abstract double CalculateSurface();

        protected virtual void ValidateSide(double side, string sideParameterName)
        {
            if (side <= 0)
            {
                throw new ArgumentException($"{sideParameterName} must be a positive number.");
            }
        }

    }
}