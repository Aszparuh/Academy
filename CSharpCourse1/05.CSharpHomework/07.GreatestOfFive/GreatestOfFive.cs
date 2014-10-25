using System;

class GreatestOfFive
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int fourthNum = int.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        int fifthNum = int.Parse(Console.ReadLine());
        int greatestNumber = 0;

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

