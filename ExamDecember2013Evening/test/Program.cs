using System;

class Program
{
    static void Main()
    {
        int number = 12345;
        for (int i = 0; number > 10; i++)
        {
            int digit = number % 10;
            number = number / 10;
            
            Console.WriteLine(number + " " + digit);
        }

    }
}

