namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameExtractor.GetFileExtension("example"));
            Console.WriteLine(FileNameExtractor.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameExtractor.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameExtractor.GetFileNameWithoutExtension("example.new.pdf"));

            var distanceCalculator = new DistanceCalculator();
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                distanceCalculator.Calculate2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                distanceCalculator.Calculate3D(5, 2, -1, 3, -6, 4));

            double width = 3;
            double height = 4;
            double depth = 5;
            var exampleParallelepiped = new Parallelepiped(width, height, depth);
            Console.WriteLine("Volume = {0:f2}", exampleParallelepiped.GetVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", exampleParallelepiped.GetDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", exampleParallelepiped.GetDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", exampleParallelepiped.GetDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", exampleParallelepiped.GetDiagonalYZ());
        }
    }
}
