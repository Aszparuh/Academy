using System;

/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

class FourDigitNumber
{
    static bool ValidateInput(string numberString)
    {
        bool isValid = true;
        if (numberString.Length > 4 || numberString.Length < 4)
        {
            isValid = false;
        }
        if (numberString[0] == '0')
        {
            isValid = false;
        }

        return isValid;
    }


    static void Main()
    {
        Console.Write("Enter four-digit number: ");
        string numberString = Console.ReadLine();
        int number = int.Parse(numberString);
        while(!ValidateInput(numberString))
        {
            Console.WriteLine("The number must be four-digit and \ncannot start with 0");
            Console.Write("Enter four-digit number again: ");
            numberString = Console.ReadLine();
            number = int.Parse(numberString);            
        }

        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;

        int sum = a + b + c + d;
        int reversed = d * 1000 + c * 100 + b * 10 + a;
        int changedPos1 = d * 1000 + a * 100 + b * 10 + c;
        int changedPos2 = a * 1000 + c * 100 + b * 10 + d;

        Console.WriteLine("Sum of the digit is: {0}",sum);
        Console.WriteLine("Reversed number: {0}", reversed);
        Console.WriteLine("Last digit first: {0}", changedPos1);
        Console.WriteLine("Exchange second and third: {0}", changedPos2);
    }
}