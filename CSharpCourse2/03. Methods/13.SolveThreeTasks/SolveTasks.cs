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
    static bool ValidateUserInput(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("The number must be possitive");
            return false;
        }
        else
        {
            return true;
        }
    }
    static bool ValidateUserInput(decimal[] sequence)
    {
        if (sequence.Length <= 0)
        {
            Console.WriteLine("The sequence must not be empty");
            return false;
        }
        else
        {
            return true;
        }
    }
    static bool ValidateUserInput(decimal a)
    {
        if (a == 0)
        {
            Console.WriteLine("A must not be equal to 0");
            return false;
        }
        else
        {
            return true;
        }
    }
    static int ReverseNumber(int number)
    {
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
        Console.WriteLine("Enter 0 to exit");
        Console.Write("===>");
    }
    static void Main()
    {
        PrintMenu();
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Clear();
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            if (ValidateUserInput(number))
            {
                Console.Write("Your number reversed is: ");
                Console.Write(ReverseNumber(number));
                Console.WriteLine();
                Main();
            }
            else Main();
        }
        else if (choice == 2)
        {
            Console.Clear();
            Console.Write("Enter the length of your sequence: ");
            int length = int.Parse(Console.ReadLine());
            decimal[] sequence = new decimal[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter value on position {0}: ", i);
                sequence[i] = decimal.Parse(Console.ReadLine());
            }
            if (ValidateUserInput(sequence))
            {
                Console.Clear();
                Console.Write("The average in your sequence is: ");
                Console.Write(CalculateAverage(sequence));
                Console.WriteLine();
                Main();
            }
            else
            {
                Main();
            }
        }
        else if (choice == 3)
        {
            Console.Clear();
            Console.WriteLine("a * x + b = 0");
            Console.Write("Enter value for a: ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Enter value for b: ");
            decimal b = decimal.Parse(Console.ReadLine());
            if (ValidateUserInput(a))
            {
                Console.WriteLine("X = ");
                Console.Write(SolveEquation(a, b));
                Main();
            }
            else
            {
                Main();
            }
        }
        else if (choice == 0)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid option");
            Main();
        }
    }
}

