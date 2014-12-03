using System;

/*Write a program to convert binary numbers to their
decimal representation.*/

class ConvertBinaryToDecimal
{
    static int[] StringToArray(string binaryNumber)
    {
        int[] array = new int[binaryNumber.Length];
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            if (binaryNumber[i] == '0')
            {
                array[i] = 0;
            }
            else if (binaryNumber[i] == '1')
            {
                array[i] = 1;
            }
            else
            {
                Console.WriteLine("The number is not valid in binary");
            }
        }
        Array.Reverse(array);
        return array;
    }
    static int ConvertToDecimal(int[] array)
    {
        int result = 0;
        int temp = 1;
        for (int i = 1; i < array.Length; i++)
        {
            if(array[i] == 1)
            {
                for (int j = 1; j < i; j++)
                {
                    temp *= 2;
                }
            }
            result += temp;
            temp = 1;
        }
        if (array[0] == 1)
        {
            return result + 1;
        }
        else
        {
            return result;
        }
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter number in binary: ");
        string binaryNumber = Console.ReadLine();
        PrintArray(StringToArray(binaryNumber));
        Console.Write("The number in decimal is: ");
        Console.Write(ConvertToDecimal(StringToArray(binaryNumber)));
        
    }
}

