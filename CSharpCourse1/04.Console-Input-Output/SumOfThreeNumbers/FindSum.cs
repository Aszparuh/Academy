using System;

/*Write a program that reads 3 real numbers from the console and prfloats their sum.*/

class FindSum
{
    static void Main()
    {
        Console.Write("Enter first Number: ");
        float firstfloat = float.Parse(Console.ReadLine());
        Console.Write("Enter second Number: ");
        float secondfloat = float.Parse(Console.ReadLine());
        Console.Write("Enter third Number: ");
        float thirdfloat = float.Parse(Console.ReadLine());
        float sum = firstfloat + secondfloat + thirdfloat;

        Console.WriteLine("The numbers are {0}, {1}, {2} and their sum is: {3} ", firstfloat, secondfloat, thirdfloat, sum);
    }
}