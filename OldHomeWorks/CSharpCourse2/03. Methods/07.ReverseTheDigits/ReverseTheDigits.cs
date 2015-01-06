using System;

class ReverseTheDigits
{
    static int TakeInput()
    {
        Console.Write("Enter your number: ");
        return int.Parse(Console.ReadLine());
    }
    static int ReverseNumber()
    {
        int number = TakeInput();
        int reversedNumber = 0;
        while(number > 0)
        {
            reversedNumber = reversedNumber * 10 + number % 10;
            number = number / 10;

        }
        return reversedNumber;
    }
    static void Main()
    {
        Console.WriteLine("Your number reversed is {0}", ReverseNumber());
    }
}

