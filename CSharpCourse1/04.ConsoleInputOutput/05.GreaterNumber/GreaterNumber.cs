using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int minNum = Math.Min(firstNum, secondNum);
        int maxNum = Math.Max(firstNum, secondNum);

        Console.WriteLine("{0} is greater than {1}.", maxNum, minNum);
    }
}

