using System;

class Compare
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNumber = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        if (firstNumber == secondNumber) 
        {
            Console.WriteLine("Numbers are equal with precision 0,000001");
        }
        else
        {
            Console.WriteLine("Numbers are not equal with precision 0,000001");
        }
    }
}

