using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int startNumber = 1;

        while (startNumber <= number)
        {
           if ((startNumber % 3 != 0) && (startNumber % 7 != 0))
           {
              Console.Write(startNumber + ", ");
            }
            startNumber++;
        }
    }
}

