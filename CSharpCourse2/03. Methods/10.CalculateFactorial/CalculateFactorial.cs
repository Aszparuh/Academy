using System;
using System.Collections.Generic;

class CalculateFactorial
{
    static List<int> MultiplyByDigit(int position, int[] shortArray, int[] longArray)
    {

        List<int> result = new List<int>();
        int residue = 0;
        int current = 0;
        for (int i = position; i > 0; i--)
        {
            result.Add(0);
        }
        for (int i = 0; i < longArray.Length; i++)
        {
            current = shortArray[position] * longArray[i] + residue;
            if (current > 9)
            {
                result.Add(current % 10);
                residue = current / 10;
            }
            else
            {
                result.Add(current);
                residue = 0;
            }
        }
        if (residue > 0)
        {
            result.Add(residue);
        }
        return result;
    }
    static List<int> AddArrays(List<int> firstArray, List<int> secondArray)
    {
        if (firstArray.Count > secondArray.Count)
        {
            return AddArrays(secondArray, firstArray);
        }
        List<int> resultArray = new List<int>();

        int residue = 0;
        for (int i = 0; i < firstArray.Count; i++)
        {
            resultArray.Add(firstArray[i] + secondArray[i] + residue);
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
        for (int i = firstArray.Count; i < secondArray.Count; i++)
        {
            resultArray.Add(secondArray[i] + residue);
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
    static List<int> SumResultDigitMultiplication(int[] shortArray, int[] longArray)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < shortArray.Length; i++)
        {
            result = AddArrays(result, MultiplyByDigit(i,shortArray,longArray));
        }
        return result;
    }
    static void PrintArray(List<int> array)
    {
        for (int i = 0; i < array.Count; i++)
        {
            if (i == array.Count - 1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write(array[i] + ", ");
            }
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] firstArray = { 1, 4, 6, 7, 8 };
        int[] secondArray = { 2, 3 };
        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        PrintArray(MultiplyByDigit(0, secondArray, firstArray));
        PrintArray(MultiplyByDigit(1, secondArray, firstArray));
        PrintArray(SumResultDigitMultiplication(secondArray, firstArray));
    }
}

