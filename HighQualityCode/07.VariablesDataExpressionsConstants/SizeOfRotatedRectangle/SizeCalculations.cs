namespace SizeOfRotatedRectangle
{
    using System;
    using SizeOfRotatedRectangle.Models;

    class SizeCalculations
    {
        static void Main()
        {
            var testRectangle = new Rectangle(25.3, 37.5);
            Console.WriteLine(testRectangle);
            var boxOfTestRectangle = testRectangle.GetBoundingBox(90);
            Console.WriteLine(boxOfTestRectangle);
        }
    }
}