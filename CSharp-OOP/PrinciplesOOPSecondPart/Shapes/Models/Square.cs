﻿namespace Shapes.Models
{
    public class Square : Shape
    {
        public Square(double side)
            : base(side, side)
        { }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}