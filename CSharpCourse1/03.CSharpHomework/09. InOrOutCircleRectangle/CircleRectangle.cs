using System;
class CircleRectangle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());
        int centerX = 1;
        int centerY = 1;

        if ((x - centerX) * (x - centerX) + (y - centerY) * (y -centerY) <= 9)
        {
            Console.WriteLine("The point is within the circle K((1,1),3)");
        }
        else
        {
            Console.WriteLine("The point is outside the cicle K((1,1),3)");
        }
        if ((y <= 1) && (y >= -1) && (x >= -1) && (x <= 5))
        {
            Console.WriteLine("The point is within the rectangle R");
        }
        else
            Console.WriteLine("The point is outside the rectangle R");
    }
}

