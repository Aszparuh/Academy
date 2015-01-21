using System;

/*Write a program that reads the coefficients a, b and c of a quadratic equation 
 * ax2 + bx + c = 0 and solves it (prints its real roots).*/

class Calculate
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("There are no real roots.");
        }
        else if (d == 0)
        {
            Console.WriteLine("There is only one root: {0}", -b / (2 * a));
        }
        else
        {
            double sqrtDisciminant = Math.Sqrt(d);
            double x1 = (-b + sqrtDisciminant) / (2 * a);
            double x2 = (-b - sqrtDisciminant) / (2 * a);
            Console.WriteLine("The roots are: {0}, {1}", x1, x2);
        }
    }
}