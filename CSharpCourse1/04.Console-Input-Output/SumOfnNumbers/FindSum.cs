using System;

/*Write a program that enters a number n and after that enters more n numbers and calculates and prfloats their sum.*/

class FindSum
{
    static void Main()
    {
        Console.Write("Enter number: ");
        float n = float.Parse(Console.ReadLine());
        float sum = 0;
        float number = 0;


        for (float i = 0; i < n; i++)
        {
            Console.Write("Enter new number to be added: ");
            number = float.Parse(Console.ReadLine());
            sum = sum + number;
        }

        Console.WriteLine("The sum is {0}", sum);
        
    }
}