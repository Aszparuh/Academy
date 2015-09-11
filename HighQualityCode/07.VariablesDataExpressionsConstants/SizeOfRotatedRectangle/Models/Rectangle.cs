namespace SizeOfRotatedRectangle.Models
{
    using System;

    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width 
        { 
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be negative or zero");
                }

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
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be negative or zero");
                }

                this.height = value;
            }
        }

        public Rectangle GetBoundingBox(double rotationAngle)
        {
            double boxWidht = this.CalculateBoundingBoxSide(rotationAngle, this.Width, this.Height);
            double boxHeight = this.CalculateBoundingBoxSide(rotationAngle, this.Height, this.Width);
            Rectangle boundingBox = new Rectangle(boxWidht, boxHeight);

            return boundingBox;
        }

        public override string ToString()
        {
            return string.Format("Width = {0}, Height = {1}", this.width, this.height);
        }

        private double CalculateBoundingBoxSide(double angle, double sideCos, double sideSin)
        {
            double dimensionCos = Math.Abs(Math.Cos(angle)) * sideCos;
            double dimensionSin = Math.Abs(Math.Sin(angle)) * sideSin;

            return dimensionCos + dimensionSin;
        }
    }
}