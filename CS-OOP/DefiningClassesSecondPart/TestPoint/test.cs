namespace TestPoint
{
    using System;
    using Point;

    class test
    {
        static void Main()
        {
            var testPoint = new Point3D(2.8, 5, 8);
            var testPoint2 = new Point3D(4, 7.5, 9);
            Console.WriteLine("First point coordinates: {0}", testPoint.ToString());
            Console.WriteLine("Second point coordinates: {0}", testPoint2.ToString());
            Console.WriteLine("Distance: {0:F}", Distance.CalcDistance(testPoint, testPoint2));

            var pathToSave = new Path();
            pathToSave.AddPoint(testPoint);
            pathToSave.AddPoint(testPoint2);
            pathToSave.AddPoint(new Point3D(8, 13, 1.5));

            PathStorage.SavePath(pathToSave);
            Console.WriteLine("Path saved to file.");

            var pathToLoad = PathStorage.LoadPath();
            Console.WriteLine("Path loaded form file.");
            foreach (var point in pathToLoad.GetPath)
            {
                Console.WriteLine(point);
            }
        }
    }
}