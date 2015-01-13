using System;

/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter value for base1 of the trapezoid: ");
        decimal base1 = decimal.Parse(Console.ReadLine());
        Console.Write("Enter value for base2 of the trapezoid: ");
        decimal base2 = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the trapezoid height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is: " + (((base1 + base2) / 2) * height));
    }
}