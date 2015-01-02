using System;

/*Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:
(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true*/

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

