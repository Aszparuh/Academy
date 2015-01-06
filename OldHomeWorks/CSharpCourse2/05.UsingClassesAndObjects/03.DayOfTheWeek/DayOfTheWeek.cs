using System;

/*Write a program that prints to the console which day
of the week is today. Use System.DateTime.*/

class DayOfTheWeek
{
    static void Main()
    {
        DateTime today = DateTime.Now;
        Console.WriteLine("Today is " + today.DayOfWeek + ".");
    }
}