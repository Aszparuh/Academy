using System;

/*Write an expression that checks if given positive integer number n 
 * (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).*/

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = false;

        if (number > 100)
        {
            Console.WriteLine("Your number is out of range.");
        }
        else if (number == 1)
        {
            Console.WriteLine(isPrime);
        }
        else if ((number == 2) || (number == 3) || (number == 5) || (number == 7))
        {
            isPrime = true;
            Console.WriteLine(isPrime);
        }
        else if ((number % 2 == 0) || (number % 3 == 0) || (number % 5 == 0) || (number % 7 == 0) || (number % 10 == 0))
        {
            Console.WriteLine(isPrime);
        }
        else
        {
            isPrime = true;
            Console.WriteLine(isPrime);
        }
    }
}