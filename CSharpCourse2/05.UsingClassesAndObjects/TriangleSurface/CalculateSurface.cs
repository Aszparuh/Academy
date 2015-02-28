namespace TriangleSurface
{
    using System;

    /*Write methods that calculate the surface of a triangle by given:
       Side and an altitude to it;
       Three sides;
       Two sides and an angle between them;
       Use System.Math.
       Example:
       
       input	output
       * a = 23.2, h = 5	58
       * a = 11, b =12, c = 13	61.48
       * a = 10, b = 7, C = 25°	14.7*/

    class CalculateSurface
    {
        static double CalculateSideHeight(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        static double CalculateThreeSides(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        static double CalculateTwoSidesAngle(double sideB, double sideC, double angleA)
        {
            angleA = angleA * Math.PI / 180; // Convert to radians
            double area = (sideC * sideB) / 2 * Math.Sin(angleA);
            return area;
        }

        static void PrintResult(double result)
        {
            Console.WriteLine("{0:0.00}", result);
        }

        static void Main()
        {
            Console.WriteLine("Select option to calculate area of triangle: ");
            Console.WriteLine("\n 1 for one side and the height \n 2 for three sides \n 3 for two sides and angle");
            Console.Write("Enter: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if (choice == 1)
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double height = double.Parse(Console.ReadLine());
                PrintResult(CalculateSideHeight(side, height));
            }
            else if (choice == 2)
            {
                Console.Write("Enter side A: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter side B: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter side C: ");
                double sideC = double.Parse(Console.ReadLine());
                PrintResult(CalculateThreeSides(sideA, sideB, sideC));
            }
            else if (choice == 3)
            {
                Console.Write("Enter first side: ");
                double sideA = double.Parse(Console.ReadLine());
                Console.Write("Enter second side: ");
                double sideB = double.Parse(Console.ReadLine());
                Console.Write("Enter angle in degrees: ");
                double angle = double.Parse(Console.ReadLine());
                PrintResult(CalculateTwoSidesAngle(sideA, sideB, angle));
            }
            else
            {
                Console.WriteLine("There is no such option");
            }
        }
    }
}