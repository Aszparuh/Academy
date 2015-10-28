namespace Shapes.Models
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return this.width;}
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width must be greater than zero.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height must be greater than zero.");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}