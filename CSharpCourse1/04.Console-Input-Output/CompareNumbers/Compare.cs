using System;

/*Write a program that gets two numbers from the console and prfloats the greater of them.
Try to implement this without if statements.*/

class Compare
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNum = float.Parse(Console.ReadLine());
        float minNum = Math.Min(firstNum, secondNum);
        float maxNum = Math.Max(firstNum, secondNum);

        Console.WriteLine("{0} is greater than {1}.", maxNum, minNum);
    }
}