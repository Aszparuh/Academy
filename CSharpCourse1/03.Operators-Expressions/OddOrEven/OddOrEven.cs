using System;

/*Write an expression that checks if given integer is odd or even.*/

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The Number is Even");
        }
        else
        {
            Console.WriteLine("The Number is Odd");
        }
    }
}