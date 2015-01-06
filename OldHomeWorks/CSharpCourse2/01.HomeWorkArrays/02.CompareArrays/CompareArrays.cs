using System;
/*Write a program that reads two arrays from the
console and compares them element by element.*/

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter the length of the arrays: ");
        int length = int.Parse(Console.ReadLine());
        int[] firstArray = new int[length];
        int[] secondArray = new int[length];
        bool equals = true;

        Console.WriteLine("Enter the numbers for the first array");

        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter element {0}: ",i + 1);
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the numbers for the second array");
        for (int i = 0; i < length; i++)
        {
            Console.Write("Enter element {0}: ",i + 1);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                equals = false;
            }
        }
        if (equals)
        {
            Console.WriteLine("The arrays are identical");
        }
        else
        {
            Console.WriteLine("The arrays are not identical");
        }
    }
}

