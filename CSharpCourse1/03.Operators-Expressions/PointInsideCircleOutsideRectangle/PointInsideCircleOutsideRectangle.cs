using System;

/*Write an expression that checks for given point (x, y) if it is within the circle 
 * K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        float x = float.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        float y = float.Parse(Console.ReadLine());
        int centerX = 1;
        int centerY = 1;

        if ((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY) <= 1.5 * 1.5)
        {
            Console.WriteLine("The point is within the circle K((1,1),1.5)");
        }
        else
        {
            Console.WriteLine("The point is outside the cicle K((1,1),1.5)");
        }
        if ((y <= 1) && (y >= -1) && (x >= -1) && (x <= 5))
        {
            Console.WriteLine("The point is within the rectangle R");
        }
        else
            Console.WriteLine("The point is outside the rectangle R");
    }
}

