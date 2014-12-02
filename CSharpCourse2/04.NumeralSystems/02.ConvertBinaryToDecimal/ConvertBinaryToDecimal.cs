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
        return array;
    }
    static int ConvertToDecimal(int[] array)
    {
        int result = 0;
        int temp = 1;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i] == 1)
            {
                for (int j = 0; j == i; j++)
                {
                    temp *= 2;
                }
            }
            result += temp;
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
    static void Main()
    {
        Console.Write("Enter number in binary: ");
        string binaryNumber = Console.ReadLine();
        Console.Write("The number in decimal is: ");
        Console.Write(ConvertToDecimal(StringToArray(binaryNumber)));
        
    }
}

