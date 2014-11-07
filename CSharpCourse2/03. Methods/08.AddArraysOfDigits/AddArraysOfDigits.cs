using System;
using System.Collections.Generic;

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
        return resultArray;
    }
    static void PrintReverse(List<int> listToPrint)
    {
        for (int i = listToPrint.Count - 1; i >= 0; i--)
        {
            Console.Write(listToPrint[i]);
        }
        Console.WriteLine();
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
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
        PrintArray(shortArray);
        Console.Write(" + ");
        PrintArray(longArray);
        Console.Write(" = ");
        List<int> result = AddArrays(shortArray, longArray);
        PrintReverse(result);
    }
}

