namespace QualityMethods.Models
{
    using System;

    public class Line : Point
    {
        const double AcceptableDifference = 0.000001;

        public Line(double x1, double y1, double x2, double y2)
            : base(x1, y1)
        {  
            this.X2 = x2;
            this.Y2 = y2;
        }

        public Line(Point firstPoint, Point secondPoint)
            : base(firstPoint.X, firstPoint.Y)
        {
            this.X2 = secondPoint.X;
            this.Y2 = secondPoint.Y;
        }

        public double X2 { get; private set; }

        public double Y2 { get; private set; }

        public bool IsHorizontal()
        {
            return Math.Abs(this.Y - this.Y2) < AcceptableDifference;
        }

        public bool IsVertical()
        {
            return Math.Abs(this.X - this.X2) < AcceptableDifference;
        }
    }
}