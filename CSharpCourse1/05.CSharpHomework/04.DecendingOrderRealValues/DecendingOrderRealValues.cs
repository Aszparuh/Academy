using System;

class DecendingOrderRealValues
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
            if (secondNum > thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", secondNum, thirdNum, firstNum);
            }
        }
        if (firstNum > secondNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", firstNum, secondNum, thirdNum);
            }
            if (secondNum < thirdNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", firstNum, thirdNum, secondNum);
            }
            if (thirdNum > firstNum)
            {
                Console.WriteLine("Values in decending order: {0}, {1}, {2}", thirdNum, firstNum, secondNum);
            }
        }
    }

}

