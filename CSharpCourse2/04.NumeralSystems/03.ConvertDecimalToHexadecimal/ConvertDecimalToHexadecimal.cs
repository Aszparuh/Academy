using System;
using System.Collections.Generic;

class ConvertDecimalToHexadecimal
{
    static List<char> ConvertToHexadecimal(int number)
    {
        List<char> array = new List<char>();
        for (int i = 0; number > 0; i++)
        {
            int temp = number & 15;
            switch (temp)
            {
                case 1: array.Add('1'); break;
                case 2: array.Add('2'); break;
                case 3: array.Add('3'); break;
                case 4: array.Add('4'); break;
                case 5: array.Add('5'); break;
                case 6: array.Add('6'); break;
                case 7: array.Add('7'); break;
                case 8: array.Add('8'); break;
                case 9: array.Add('9'); break;
                case 10: array.Add('A'); break;
                case 11: array.Add('B'); break;
                case 12: array.Add('C'); break;
                case 13: array.Add('D'); break;
                case 14: array.Add('E'); break;
                case 15: array.Add('F'); break;
                case 0: array.Add('0'); break;
                default: Console.WriteLine("Error");
                    break;
            }
            number >>= 4;
        }
        array.Reverse();
        return array;
    }
    static void PrintArray(List<char> array)
    {
        Console.Write("0x");
        for (int i = 0; i < array.Count; i++)
        {
            Console.Write(array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("The number in hexadecimal is: ");
        PrintArray(ConvertToHexadecimal(number));
    }
}

