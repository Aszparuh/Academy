namespace Abstraction
{
    using System;

    public abstract class Figure
    {
        public override string ToString()
        {
            return string.Format("{0}, Perimeter:{1}, Area:{2}", this.GetType().Name, this.CalculatePerimeter(), this.CalculateArea());
        }

        internal abstract double CalculatePerimeter();

        internal abstract double CalculateArea();
    }
}