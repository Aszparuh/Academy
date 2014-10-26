using System;

/*Write a method that returns the last digit of given
integer as an English word. Examples: 512   "two",
1024   "four", 12309   "nine".*/

class LastDigitAsWord
{
    static string DigitToWord(int num) 
    {
        switch (num)
        {
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            case 0: return "zero";

            default: return "Something is wrong";

        }
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        number = number % 10;
        Console.WriteLine("The last digit is {0}.", DigitToWord(number));
    }
}

