using System;

/*Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).*/

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        int radius = 2;

        if ((x * x) + (y * y) <= radius * radius)
        {
            Console.WriteLine("The point is in the circle K({0, 0}, 2)");
        }
        else
        {
            Console.WriteLine("The point is not in the circle K({0, 0}, 2)");
        }
    }
}