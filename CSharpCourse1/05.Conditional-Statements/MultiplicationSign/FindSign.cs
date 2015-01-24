using System;

/*Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.*/

class FindSign
{
    static void Main()
    {
        Console.Write("Enter value for a: ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        float c = float.Parse(Console.ReadLine());

        if (a < 0 ^ b < 0 ^ c < 0)
        {
            Console.WriteLine("The sign of the product is \"-\"");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("The product is \"0\"");
        }
        else
        {
            Console.WriteLine("The sign of the product is \"+\"");
        }
    }
}