using System;

/*Declare five variables choosing for each of them the most appropriate of 
the types byte, sbyte, short, ushort, int, uint, long, ulong to represent 
the following values: 52130, -115, 4825932, 97, -10000.*/

class FiveVariables
{
    static void Main()
    {
        ushort firstNumber = 52130;
        sbyte secondNumber = -115;
        int thirdNumber = 4825932;
        sbyte fourthNumber = 97;
        short fifthNumber = -10000;

        Console.WriteLine("First Number is: " + firstNumber);
        Console.WriteLine("Second Number is: " + secondNumber);
        Console.WriteLine("Third Number is: " + thirdNumber);
        Console.WriteLine("Fourth Number is: " + fourthNumber);
        Console.WriteLine("Fifth Number is: " + fifthNumber);
    }
}

