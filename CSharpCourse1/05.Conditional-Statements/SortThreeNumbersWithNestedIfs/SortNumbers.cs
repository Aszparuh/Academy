using System;

/*Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.*/

class SortNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());

        if (firstNum < secondNum)
        {
            if (secondNum < thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", thirdNum, secondNum, firstNum);
            }
            else if (secondNum > thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", secondNum, thirdNum, firstNum);
            }
            else
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", thirdNum, secondNum, firstNum);
            }
        }
        if (firstNum > secondNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", firstNum, secondNum, thirdNum);
            }
            else if (secondNum < thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", firstNum, thirdNum, secondNum);
            }
            else if (thirdNum > firstNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", thirdNum, firstNum, secondNum);
            }
            else
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", firstNum, thirdNum, secondNum);
            }
        }
        if (firstNum == secondNum)
        {
            if (thirdNum > secondNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", thirdNum, secondNum, firstNum);
            }
            else
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", secondNum, firstNum, thirdNum);
            }
        }
    }
}