using System;

/*Write a program that enters from the console a positive integer n and 
 * prints all the numbers from 1 to n, on a single line, separated by a space.*/

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int startNumber = 1;

        Console.Write(startNumber + " ");
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
                Console.Write(startNumber + " ");
            }
        }
    }
}