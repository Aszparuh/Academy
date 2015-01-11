using System;

/*Write an expression that checks for given integer if its third digit from right-to-left is 7.*/

class CheckThirdDigit
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());
        number /= 100;
        number %= 10;

        if (number == 7)
        {
            Console.WriteLine("The third digit is seven.");
        }
        else
        {
            Console.WriteLine("The third digit is not seven.");
        }
    }
}