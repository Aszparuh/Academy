using System;

/*Write methods that calculate the surface of a
triangle by given:
 Side and an altitude to it; Three sides; Two sides
and an angle between them. Use System.Math.*/

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
        angleA = angleA * Math.PI / 180;
        double area = (sideC * sideB) / 2 * Math.Sin(angleA);
        return area;
    }

    static void Main()
    {

    }
}