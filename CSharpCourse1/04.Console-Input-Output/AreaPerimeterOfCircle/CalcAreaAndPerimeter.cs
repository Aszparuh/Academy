using System;
using System.Threading;
using System.Globalization;

/*Write a program that reads the radius r of a circle and prints its 
 * perimeter and area formatted with 2 digits after the decimal point.*/

class CalcAreaAndPerimeter
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture; //Format no matter of the current culture of the system
        Console.Write("Enter the radius of your circle: ");
        double radius = double.Parse(Console.ReadLine());
        double pi = Math.PI;

        Console.WriteLine("The circle's perimeter is {0:F2} and area is {1:F2}", pi * (radius + radius), pi * radius * radius);
    }
}