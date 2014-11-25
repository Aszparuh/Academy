using System;

/*Write a program that can solve these tasks:
 Reverses the digits of a number
 Calculates the average of a sequence of integers
 Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to
choose which task to solve.
Validate the input data:
 The decimal number should be non-negative
 The sequence should not be empty
 a should not be equal to 0*/

class SolveTasks
{
    static int ReverseNumber(int number)
    {
        Console.Write("Enter number: ");
        int reversedNumber = 0;
        while (number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number = number / 10;
        }
        return reversedNumber;
    }
    static decimal CalculateAverage(decimal[] sequence)
    {
        decimal numberOfElements = sequence.Length;
        decimal sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum = sum + sequence[i];
        }
        return sum / numberOfElements;
    }
    static decimal SolveEquation(decimal a, decimal b)
    {
        decimal x = -b / a;
        return x;
    }
    static void PrintMenu()
    {
        Console.WriteLine("Choose one of the three tasks");
        Console.WriteLine("Enter 1 to reverse the digits of a number.");
        Console.WriteLine("Enter 2 to calculate the average of a sequence of integers.");
        Console.WriteLine("Enter 3 to solve a linear equation a * x + b = 0.");
    }
    static void Main()
    {
    }
}

