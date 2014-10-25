using System;

class From1ToN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int startNumber = 1;

        Console.Write(startNumber);
        while (startNumber <= number)
        {
            if (startNumber == number)
            {
                Console.WriteLine();
                break;
            }
            else
            {
                startNumber++;
                Console.WriteLine(startNumber);
            }
        }
    }
}

