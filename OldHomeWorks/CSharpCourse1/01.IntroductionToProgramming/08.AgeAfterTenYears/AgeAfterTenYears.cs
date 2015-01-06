using System;

/*rite a program to read your age from the console and print how old you will be after 10 years.*/

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        byte age = byte.Parse(Console.ReadLine()); //byte.Parse - Converts the string representation of a number to its Byte equivalent.
        Console.WriteLine("After ten years you will be {0} years old.", age + 10);
    }
}