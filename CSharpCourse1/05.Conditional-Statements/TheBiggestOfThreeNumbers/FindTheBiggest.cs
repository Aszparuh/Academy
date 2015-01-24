using System;

/*Write a program that finds the biggest of three numbers.*/

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

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("The first number is the greatest: {0}", firstNum);
            }
            else if (firstNum == thirdNum)
            {
                Console.WriteLine("The third and first numbers are equal and bigger than the second: {0}, {1}", firstNum, thirdNum);
            }
            else
            {
                Console.WriteLine("The third number is the greatest: {0}", thirdNum);
            }
        }
        if (firstNum < secondNum)
        {
            if (secondNum > thirdNum)
            {
                Console.WriteLine("The second number is the greatest: {0}", secondNum);
            }
            else if (secondNum == thirdNum)
            {
                Console.WriteLine("the second and the third numbers are equal and bigger than the first: {0}, {1}", secondNum, thirdNum);
            }
            else
            {
                Console.WriteLine("The third number is the greatest: {0}", thirdNum);
            }
        }
        if (firstNum == secondNum)
        {
            if (firstNum == thirdNum)
            {
                Console.WriteLine("all the numbers are equal.");
            }
            else if (firstNum > thirdNum)
            {
                Console.WriteLine("First and second numbers are equal and the third is the greatest: {0}", thirdNum);
            }
            else
            {
                Console.WriteLine("First and second numbers are equal and bigger than the third: {0}, {1}", firstNum, secondNum);
            }
        }
    }
}