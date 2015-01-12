using System;

/*The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.*/

class MoonGravity
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        decimal weight = decimal.Parse(Console.ReadLine());
        decimal moonGravity = 17;
        decimal weightOnMoon = moonGravity / 100 * weight;
        Console.WriteLine("The weight on the Moon will be: {0}" ,weightOnMoon);
    }
}