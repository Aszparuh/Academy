using System;

class AreaOfRectabngle
{
    static void Main()
    {
        Console.Write("Enter  width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle area is: " + height * width);
    }
}

