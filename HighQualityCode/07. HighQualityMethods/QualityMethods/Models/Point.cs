namespace QualityMethods.Models
{
    using System;

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }

        public double CalculateDistance(double x, double y)
        {
            double distance = Math.Sqrt((x - this.X) * (x - this.X) + (y - this.Y) * (y - this.Y));
            return distance;
        }
    }
}