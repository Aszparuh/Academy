namespace TestCalculateSurface
{
    using System;
    using Shapes.Models;
    class Test
    {
        static void Main()
        {
            Shape[] shapes = new Shape[] { new Square(2.5), new Rectangle(3, 4.7), new Triangle(8, 3.5) };
            foreach (var shape in shapes)
            {
                Console.WriteLine("The surface of {0} is:  {1}", shape.GetType(), shape.CalculateSurface());
            }
        }
    }
}