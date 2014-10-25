using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal number = 0;
        decimal secondNumber = 1m;

        for (int i = 0; i < 100; i++)
        {
            decimal thirdNumber = number + secondNumber;
            
            Console.WriteLine(thirdNumber + ", ");
            number = secondNumber;
            secondNumber = thirdNumber;
            
        }
    }
}

