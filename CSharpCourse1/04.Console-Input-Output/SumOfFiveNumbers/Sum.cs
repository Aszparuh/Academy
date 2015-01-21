using System;

/*Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum*/

class Sum
{
    static void Main()
    {
        float sum = 0;
        string[] allNumbersAsStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[allNumbersAsStrings.Length];

        for (int i = 0; i < allNumbersAsStrings.Length; i++)
        {
            numbers[i] = int.Parse(allNumbersAsStrings[i]);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        Console.WriteLine("The sum is {0}", sum);
    }
}