namespace TestPoint
{
    using System;
    using Point;

    class test
    {
        static void Main(string[] args)
        {
            var testPoint = new Point3D(2.8, 5, 8);
            var testPoint2 = new Point3D(4, 7.5, 9);
            Console.WriteLine("First point coordinates: {0}", testPoint.ToString());
            Console.WriteLine("Second point coordinates: {0}", testPoint2.ToString());
            Console.WriteLine("Distance: {0:F}", Distance.CalcDistance(testPoint, testPoint2));
        }
    }
}