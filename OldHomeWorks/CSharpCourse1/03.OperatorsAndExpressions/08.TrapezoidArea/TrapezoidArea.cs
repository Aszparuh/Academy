using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter value for base1 of the trapezoid: ");
        int base1 = int.Parse(Console.ReadLine());
        Console.Write("Enter value for base2 of the trapezoid: ");
        int base2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the trapezoid height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("The area of the trapezoid is: " + (((base1 + base2)/2)*height));
    }
}

