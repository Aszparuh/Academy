using System;

/*Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.*/

class Format
{
    static void Main()
    {
        int a = -1;
        while (a < 0 || a > 500)
        {
            Console.Write("Enter integer number (0 <= number <= 500): ");
            a = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Enter floating-point number: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Enter floating-point number: ");
        float c = float.Parse(Console.ReadLine());
        string binaryA = Convert.ToString(a, 2).PadLeft(10, '0');
        
        //Print and format
        Console.WriteLine("{0,-10:X}*{1}*{2,10:F2}*{3,-10:0.###}*", a, binaryA, b, c);
    }
}