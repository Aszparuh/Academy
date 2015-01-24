using System;

/*Write a program that finds the biggest of five numbers by using only five if statements.*/

class FindTheBiggest
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        float secondNum = float.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        float thirdNum = float.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        float fourthNum = float.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        float fifthNum = float.Parse(Console.ReadLine());
        float greatestNumber = 0;

        if ((firstNum > secondNum) && (firstNum > thirdNum) && (firstNum > fourthNum) && (firstNum > fifthNum))
        {
            greatestNumber = firstNum;
        }
        else if ((secondNum > firstNum) && (secondNum > thirdNum) && (secondNum > fourthNum) && (secondNum > fifthNum))
        {
            greatestNumber = secondNum;
        }
        else if ((thirdNum > firstNum) && (thirdNum > secondNum) && (thirdNum > fourthNum) && (thirdNum > firstNum))
        {
            greatestNumber = thirdNum;
        }
        else if ((fourthNum > firstNum) && (fourthNum > secondNum) && (fourthNum > thirdNum) && (fourthNum > fifthNum))
        {
            greatestNumber = fourthNum;
        }
        else
        {
            greatestNumber = fifthNum;
        }
        Console.WriteLine("The greatest number is {0}", greatestNumber);
    }
}