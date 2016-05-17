namespace TriangleSurfaceByThreeSides
{
    using System;

    class Start
    {
        static void Main()
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());

            var area = CalculateThreeSides(sideA, sideB, sideC);
            Console.WriteLine("{0:0.00}", area);
        }

        static double CalculateThreeSides(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

    }
}
