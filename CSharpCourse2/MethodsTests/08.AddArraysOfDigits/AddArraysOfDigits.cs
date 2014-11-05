using System;
using System.Collections.Generic;

class AddArraysOfDigits
{
    static int FindGreatestLength(string first, string second)
    {
        if (first.Length > second.Length)
        {
            return first.Length;
        }
        else
        {
            return second.Length;
        }
    }
    static int[] ConvertToArray(string anyString, int length)
    {
        int[] stringToArray = new int[length];
        if (anyString.Length < length)
        {
            for (int i = 0; i < anyString.Length; i++)
            {
                stringToArray[i] = Convert.ToInt32(anyString[i] - 48);
            }
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                stringToArray[i] = Convert.ToInt32(anyString[i] - 48);
            }
        }
        return stringToArray;
    }
    static List<int> AddArrays(int[] firstArray, int[] secondArray)
    {
        List<int> sumArray = new List<int>();
        int residue = 0;
        for (int i = firstArray.Length - 1; i >= 0; i--)
        {
            sumArray.Add(firstArray[i] + secondArray[i] + residue);
            if ((firstArray[i] + secondArray[i] + residue) >= 10)
            {
                residue = 1;
                sumArray[i] = sumArray[i] % 10;
            }
            else
            {
                residue = 0;
            }
            if (i == firstArray.Length - 1 && residue == 1)
            {
                sumArray.Add(1);
            }
        }
        return sumArray;
    }
    static void PrintArray(List<int> arrayToPrint)
    {
        for (int i = 0; i < arrayToPrint.Count; i++)
        {
            Console.Write(arrayToPrint[i]);
        }
    }
    static void Main()
    {
        Console.Write("Enter first number: ");
        string firstString = Console.ReadLine();
        Console.Write("Enter second number: ");
        string secondString = Console.ReadLine();
        int greatestLength = FindGreatestLength(firstString, secondString);
        int[] firstArray = ConvertToArray(firstString, greatestLength);
        int[] secondArray = ConvertToArray(secondString, greatestLength);
        List<int> result = AddArrays(firstArray, secondArray);
        PrintArray(result);

    }
  
}

