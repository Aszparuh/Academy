namespace TrianglesurfaceByTwoSidesAndAnAngle
{
    using System;

    class Start
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            var area = CalculateTwoSidesAngle(sideA, sideB, angle);
            Console.WriteLine("{0:0.00}", area);
        }

        static double CalculateTwoSidesAngle(double sideB, double sideC, double angleA)
        {
            angleA = angleA * Math.PI / 180; // Convert to radians
            double area = (sideC * sideB) / 2 * Math.Sin(angleA);
            return area;
        }
    }
}
