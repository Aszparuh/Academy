using System;

/*Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.*/

class PrintRandom
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            int newRandomNumber = randomGenerator.Next(1, n + 1);
            bool numberFound = false;
            while (!numberFound)
            {
                bool isTheNumber = true;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == newRandomNumber)
                    {
                        isTheNumber = false;
                    }
                    if (isTheNumber && j == numbers.Length - 1 && numbers[j] != newRandomNumber)
                    {
                        numberFound = true;
                        numbers[i] = newRandomNumber;
                        break;
                    }
                }

                newRandomNumber = randomGenerator.Next(1, n + 1);
            }
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine();
    }
}