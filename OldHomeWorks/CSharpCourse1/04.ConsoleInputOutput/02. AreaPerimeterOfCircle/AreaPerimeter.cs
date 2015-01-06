using System;
using System.Threading;
using System.Globalization;

class AreaPerimeter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the radius of your circle: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;

        Console.WriteLine("The circle's perimeter is {0} and area is {1}", pi * (radius + radius), pi * radius * radius);
    }
}

