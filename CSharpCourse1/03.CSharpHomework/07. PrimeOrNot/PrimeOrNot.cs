using System;
class PrimeOrNot
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 100)
        {
            Console.WriteLine("Your number is out of range.");
        }
        else if (number == 1)
        {
            Console.WriteLine("One is not prime.");
        }
        else if ((number == 2) || (number == 3) || (number == 5) || (number == 7))
        {
            Console.WriteLine("The number is prime.");
        }
        else if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0) || (number % 10 == 0))
        {
            Console.WriteLine("The number is not prime.");
        }
        else
        {
            Console.WriteLine("The number is prime.");
        }
    }
}

