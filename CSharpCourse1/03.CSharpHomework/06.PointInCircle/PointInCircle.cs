using System;
class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        if ((x * x)+(y * y) == 25)
        {
            Console.WriteLine("The point is in the circle K(0,5)");
        }
        else
        {
            Console.WriteLine("The point is not in the circle K(0,5)");
        }
    }
}

