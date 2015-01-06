using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

/*Write a program to calculate n! for each n in the
range [1..100]. Hint: Implement first a method
that multiplies a number represented as array of
digits by given integer number.*/

class CalculateFactorial
{
    static List<int> MultiplyByDigit(int position, List<int> shortArray, List<int> longArray)
    {

        List<int> result = new List<int>();
        int residue = 0;
        int current = 0;
        for (int i = position; i > 0; i--)
        {
            result.Add(0);
        }
        for (int i = 0; i < longArray.Count; i++)
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
    static List<int> SumResultDigitMultiplication(List<int> shortArray, List<int> longArray)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < shortArray.Count; i++)
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
                Console.Write(array[i]);
            }
        }
        Console.WriteLine();
    }
    static List<int> StringToList(string anyString)
    {
        List<int> array = new List<int>();
        for (int i = 0; i < anyString.Length; i++)
        {
            array.Add ((int)(anyString[i] - 48));
        }
        return array;
    }
    static void Main()
    {
        Console.WriteLine("Calculate Factorial");
        Console.Write("Enter number: ");
        string number = Console.ReadLine();
        Stopwatch timer = new Stopwatch();
        timer.Start();
        int numberAsInteger = int.Parse(number);
        List<int> firstArray = StringToList(number);
        firstArray.Reverse();
        for (int i = numberAsInteger - 1; i > 0; i--)
        {
            string nextNumber = i.ToString();
            List<int> secondArray = StringToList(nextNumber);
            secondArray.Reverse();
            firstArray = SumResultDigitMultiplication(firstArray, secondArray);
        }
        timer.Stop();
        Console.WriteLine();
        Console.Write(number + "!" + " " + "= ");
        firstArray.Reverse();
        PrintArray(firstArray);
        Console.WriteLine();
        Console.WriteLine(timer.Elapsed);
    }
}

