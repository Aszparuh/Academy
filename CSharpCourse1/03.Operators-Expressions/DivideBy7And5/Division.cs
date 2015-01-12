using System;

/*Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.*/

class Division
{
    static void Main()
    {
        Console.Write("Enter a Number: ");
        int number = int.Parse(Console.ReadLine());
        bool isDivided = false;

        if ((number % 5 == 0) && (number % 7 == 0))
        {
            isDivided = true;
        }
        if (isDivided)
        {
            Console.WriteLine("The number can be divided by 7 and 5 without remainder");
        }
        else
        {
            Console.WriteLine("The number cannot be divided by both 5 and 7 without reminder");
        }
    }
}