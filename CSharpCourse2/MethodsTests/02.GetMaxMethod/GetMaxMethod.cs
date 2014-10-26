using System;

/*Write a method GetMax() with two parameters that
returns the bigger of two integers. Write a program
that reads 3 integers from the console and prints the
biggest of them using the method GetMax().*/

class GetMaxMethod
{
    static int GetMax(int firstNumber, int secondNumber)
    {
        if (firstNumber > secondNumber)
        {
            return firstNumber;
        }
        else if (firstNumber < secondNumber)
        {
            return secondNumber;
        }
        else
        {
            return firstNumber;
        }
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.WriteLine("The biggest number is {0}.", GetMax(GetMax(firstNum, secondNum), thirdNum));  
    }
}

