using System;

class NumbersBetween
{
    static void Main()
    {
        Console.WriteLine("First number should be smaller than the second");
        Console.Write("Enter first number: ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNum = int.Parse(Console.ReadLine());
        int count = 0;


        for (int i = firstNum + 1; i < secondNum; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                int dinisibleNum = i;
                Console.Write("/ " + dinisibleNum);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("There are {0} number between {1} and {2} divisible by 5 without reminder.", count, firstNum, secondNum);
    }
}

