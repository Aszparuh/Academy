using System;
using System.Collections.Generic;

class AddArraysOfDigits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string firstString = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondString = Console.ReadLine();
        string smallerString;
        string biggerString;

        if (firstString.Length < secondString.Length)
        {
            smallerString = firstString;
            biggerString = secondString;
        }
        else if (secondString.Length < firstString.Length)
        {
            smallerString = secondString;
            biggerString = firstString;
        }
        else
        {
            smallerString = firstString;
            biggerString = secondString;
        }
        int[] shortArray = new int[smallerString.Length];
        int[] longArray = new int[biggerString.Length];
        for (int i = 0; i < shortArray.Length; i++)
        {
            shortArray[i] = Convert.ToInt32(smallerString[i] - 48);
        }
        for (int i = 0; i < longArray.Length; i++)
        {
            longArray[i] = Convert.ToInt32(biggerString[i] - 48);
        }
        //test
        int[] resultArray = AddArrays(shortArray, longArray);
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write(resultArray[i]);
        }
        Console.WriteLine();
    }
    static int[] AddArrays(int[] shortArray, int[] longArray)
    {
        int[] resultArray = new int[longArray.Length + 1];
        int carry = 0;
        for (int i = shortArray.Length - 1; i >= 0; i--)
        {
            resultArray[i + 1] = shortArray[i] + longArray[i] + carry;
            if (resultArray[i + 1] >= 10)
            {
                carry = 1;
                resultArray[i + 1] = resultArray[i + 1] % 10;
            }
            else
            {
                carry = 0;
                resultArray[i + 1] = resultArray[i + 1] % 10;
            }
        }
        return resultArray;
    }
}

