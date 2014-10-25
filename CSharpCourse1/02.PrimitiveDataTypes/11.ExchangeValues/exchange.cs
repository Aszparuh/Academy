using System;
class exchange
{
    static void Main()
    {
        int firstNum = 5;
        int secondNum = 10;
        int help = 0;

        Console.WriteLine("First Number is: " + firstNum);
        Console.WriteLine("Second Number is: "+ secondNum);
        Console.WriteLine("Exchanging Values");

        help = firstNum;
        firstNum = secondNum;
        secondNum = help;

        Console.WriteLine("First Number is: " + firstNum);
        Console.WriteLine("Second Number is: " + secondNum);
    }
}

