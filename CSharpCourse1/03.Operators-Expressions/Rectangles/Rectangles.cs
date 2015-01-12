using System;

/*Write an expression that calculates rectangle’s perimeter and area by given width and height.*/

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter width: ");
        float width = float.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        float height = float.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle area is: {0} the perimeter is: {1}", height * width, 2 * (height + width));
    }
}