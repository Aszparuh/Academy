using System;

class SumThreeIntegers
{
    static void Main()
    {
        Console.Write("Enter first Number: ");
        int firstInt = int.Parse(Console.ReadLine());
        Console.Write("Enter second Number: ");
        int secondInt = int.Parse(Console.ReadLine());
        Console.Write("Enter third Number: ");
        int thirdInt = int.Parse(Console.ReadLine());
        int sum = firstInt + secondInt + thirdInt;

        Console.WriteLine("The numbers are {0}, {1}, {2} and their sum is: {3} ", firstInt, secondInt, thirdInt, sum);
    }
}

