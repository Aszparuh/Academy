namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private const string InvalidWidth = "Widht cannot be negative or zero";
        private const string InvalidHeight = "Height cannot be negative or zero";

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
                    throw new ArgumentException(Rectangle.InvalidWidth);
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
                    throw new ArgumentException(Rectangle.InvalidHeight);
                }

                this.height = value;
            }
        }

        internal override double CalculatePerimeter()
        {
            return 2 * (this.Width + this.Height);
        }

        internal override double CalculateArea()
        {
            return this.Height * this.Width;
        }
    }
}