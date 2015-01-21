using System;

/*Write a program that reads a number n and prints on the console the first n members of the 
 * Fibonacci sequence (at a single line, separated by comma and space - ,)
 * : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….*/

class PrintSequence
{
    static void Main()
    {
        Console.Write("Enter how many numbers from Fibonacci sequence to print: ");
        int lenght = int.Parse(Console.ReadLine());
        int number = 0;
        int secondNumber = 1;

        for (int i = 0; i < lenght; i++)
        {
            int thirdNumber = number + secondNumber;
            if (i == lenght - 1)
            {
                Console.Write(thirdNumber);
                number = secondNumber;
                secondNumber = thirdNumber;
                Console.WriteLine();
            }
            else
            {
                Console.Write(thirdNumber + ", ");
                number = secondNumber;
                secondNumber = thirdNumber;
            }
        }
    }
}