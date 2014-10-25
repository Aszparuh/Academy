using System;
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

