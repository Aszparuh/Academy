namespace QualityMethods.Models
{
    using System;

    public static class TriangleAreaCalculator
    {
        public static double Calculate(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("One of the sides is 0 or negative");
            }

            if (sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
            {
                throw new ArgumentException("The sides cannot form triangle Triangle Inequality Theorem");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter -sideC));
            return area;
        }
    }
}