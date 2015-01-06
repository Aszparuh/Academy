using System;

/*Write a program that reads a year from the console
and checks whether it is a leap. Use DateTime.*/

class CheckLeapYear
{
    static void Main()
    {
        Console.Write("Enter year to check if it is a leap year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        if (isLeap)
        {
            Console.WriteLine("{0} is leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not leap year.", year);
        }
    }
}