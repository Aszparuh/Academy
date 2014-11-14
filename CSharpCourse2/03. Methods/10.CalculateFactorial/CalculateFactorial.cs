using System;
using System.Collections.Generic;

class CalculateFactorial
{
    static List<int> MultiplyByDigit(int position, int[] shortArray, int[] longArray)
    {
        List<int> result = new List<int>();
        int residue = 0;
        for (int i = position; i == 0; i--)
        {
            result.Add(0);
        }
        for (int i = 0; i < longArray.Length; i++)
        {
            result.Add(shortArray[position] * longArray[i] + residue);
            if (shortArray[position] * longArray[i] + residue > 9)
            {
                result[i] = (shortArray[position] * longArray[i] + residue) % 10;
                residue = (shortArray[position] * longArray[i] + residue) / 10;
            }
            else
            {
                residue = 0;
            }
        }
        return result;
    }
    static List<int> AddArrays(List<int> shortArray, List<int> longArray)
    {

        List<int> resultArray = new List<int>();

        int residue = 0;
        for (int i = 0; i < shortArray.Count; i++)
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
        for (int i = shortArray.Count; i < longArray.Count; i++)
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
    static List<int> SumResultDigitMultiplication(int[] shortArray, int[] longArray)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < shortArray.Length; i++)
        {
            result = AddArrays(result, MultiplyByDigit(i,shortArray,longArray));
        }
        return result;
    }
    static void Main()
    {
        
    }
}

