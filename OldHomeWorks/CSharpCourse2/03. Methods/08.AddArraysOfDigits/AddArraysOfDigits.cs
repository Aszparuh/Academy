using System;
using System.Collections.Generic;

/*Write a method that adds two positive integer
numbers represented as arrays of digits (each array
element arr[i] contains a digit; the last digit is
kept in arr[0]). Each of the numbers that will be
added could have up to 10 000 digits.*/

class AddArraysOfDigits
{
    static int[] StringToArray(string anyString)
    {
        int[] array = new int[anyString.Length];
        for (int i = 0; i < anyString.Length; i++)
        {
            array[i] = (int)(anyString[i] - 48);
        }
        return array;
    }

    static List<int> AddArrays(int[] shortArray, int[] longArray)
    {
        Array.Reverse(shortArray);
        Array.Reverse(longArray);
        List<int> resultArray = new List<int>();

        int residue = 0;
        for (int i = 0; i < shortArray.Length; i++)
        {
            resultArray.Add(shortArray[i] + longArray[i] + residue);
            if (resultArray[i] > 9)
            {
                residue = 1;
                resultArray[i] %= 10;
            }
            else
            {
                residue = 0;
            }
        }
        for (int i = shortArray.Length; i < longArray.Length; i++)
        {
            resultArray.Add(longArray[i] + residue);
            if (resultArray[i] > 9)
            {
                residue = 1;
                resultArray[i] %= 10;
            }
            else
            {
                residue = 0;
            }
        }
        
        if (residue == 1)
        {
            resultArray.Add(1);
        }
        resultArray.Reverse();
        return resultArray;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
    }

    static void PrintArray(List<int> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i]);
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        string firstString = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondString = Console.ReadLine();
        string shortString;
        string longString;
        
        if (firstString.Length <= secondString.Length)
        {
            shortString = firstString;
            longString = secondString;
        }
        else
        {
            shortString = secondString;
            longString = firstString;
        }
       
        int[] shortArray = StringToArray(shortString);
        int[] longArray = StringToArray(longString);
        Console.WriteLine();
        PrintArray(shortArray);
        Console.Write(" + ");
        PrintArray(longArray);
        Console.Write(" = ");
        List<int> result = AddArrays(shortArray, longArray);
        PrintArray(result);
        Console.WriteLine();
    }
}