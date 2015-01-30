using System;

/*Write a program that enters from the console a positive integer n and prints 
 * all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.*/

class PrintNumbers
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
                Console.Write(startNumber + " ");
            }
            startNumber++;
        }
    }
}