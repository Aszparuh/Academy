namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        internal override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Radius;
        }

        internal override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }
    }
}