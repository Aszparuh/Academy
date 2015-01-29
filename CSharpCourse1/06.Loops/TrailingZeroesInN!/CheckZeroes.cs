using System;

/*Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.*/

class CheckZeroes
{
    static void Main()
    {
        Console.Write("Enter N!: ");
        string input = Console.ReadLine();
        int n = int.Parse(input);

        int count = 0;
        int five = 5;
        int denominator = 0;
        int powerFive = 1;

        while (denominator <= n)
        {
            denominator = (int)Math.Pow(five, powerFive);
            count += n / denominator;
            powerFive++;
        }
        Console.WriteLine(count);
    }
}