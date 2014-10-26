using System;

class ProductOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int thirdNum = int.Parse(Console.ReadLine());


        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("One of the numbers is zero and the product is zero");
        }
        else if (firstNum < 0 ^ secondNum < 0 ^ thirdNum < 0)
        {
            Console.WriteLine("The product is negative.");
        }
        else
        {
            Console.WriteLine("The product is positive.");
        }
        

    }
}