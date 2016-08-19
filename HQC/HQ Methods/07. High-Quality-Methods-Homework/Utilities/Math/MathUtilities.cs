namespace Methods
{
    using System;

    public static class MathUtilities
    {
        // Because of double type's nature this constant is needed to compare
        // two double numbers. i.e. bool = ((1.6d + 1.6d + 1.6d) / 3.0d) == 1.6d
        // returns false
        private const double FloatingPointComparePrecision = 0.0000001;

        public static double CalculateTriangleArea(double a, double b, double c)
        {
            ValidateTriangle(a, b, c);

            double halfPerimeter = (a + b + c) / 2;
            double area = 
                Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));

            return area;
        }

        public static string DigitToWord(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    throw new ArgumentException("Invalid digit");
            }
        }

        public static int FindMaxElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException("Elements cannot be null or empty.");
            }

            int maxElement = elements[0];
            for (int currentElement = 1; currentElement < elements.Length; currentElement++)
            {
                if (elements[currentElement] > maxElement)
                {
                    maxElement = elements[currentElement];
                }
            }

            return maxElement;
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));

            return distance;
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            bool isHorizontal = Math.Abs(y1 - y2) < FloatingPointComparePrecision;

            return isHorizontal;
        }

        public static bool IsVertical(double x1, double x2)
        {
            bool isVertical = Math.Abs(x1 - x2) < FloatingPointComparePrecision;

            return isVertical;
        }

        private static void ValidateTriangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Invalid sides. All sides must be positive numbers.");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException(
                    "Invalid triangle. The sum of two sides cannot be less or equal to the third side.");
            }
        }
    }
}