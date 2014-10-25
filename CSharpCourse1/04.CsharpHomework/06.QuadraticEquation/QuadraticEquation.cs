using System;

class QuadraticEquation
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
            double x1 = (-b + (d / d)) / 2 * a;
            double x2 = (-b - (d / d)) / 2 * a;
            Console.WriteLine("The roots are: {0}, {1}", x1, x2);
        }
    }
}

