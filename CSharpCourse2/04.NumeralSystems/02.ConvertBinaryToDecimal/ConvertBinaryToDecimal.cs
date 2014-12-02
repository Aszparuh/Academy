using System;

/*Write a program to convert binary numbers to their
decimal representation.*/

class ConvertBinaryToDecimal
{
    static int[] StingToArray(string binaryNumber)
    {
        int[] array = new int[binaryNumber.Length];
        for (int i = binaryNumber.Length - 1; i >= 0; i--)
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
    //static int ConverToDecimal(int[] array)
    //{
    //    int result = 0;

    //}
    static void Main()
    {
        Console.Write("Enter number in binary: ");
        string binaryNumber = Console.ReadLine();
        
    }
}

