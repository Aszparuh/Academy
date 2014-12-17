using System;
using System.Collections.Generic;

/*Write a method that calculates the number of
workdays between today and given date, passed as
parameter. Consider that workdays are all days from
Monday to Friday except a fixed list of public
holidays specified preliminary as array.*/

class NumberOfWorkDays
{
    static DateTime GetEndDate()
    {
        DateTime endDate = new DateTime();
        Console.Write("Enter year: ");
        endDate = endDate.AddYears(int.Parse(Console.ReadLine()) - 1);
        Console.Write("Enter month: ");
        endDate = endDate.AddMonths(int.Parse(Console.ReadLine()) - 1);
        Console.Write("Enter day of the month: ");
        endDate = endDate.AddDays(int.Parse(Console.ReadLine()) - 1);
        return endDate;
    }

    static int CountWorkingDays(DateTime startDate, DateTime endDate)
    {
        int numberOfDays = (endDate - startDate).Days;
        int workingDays = 0;
        DateTime tempDate = new DateTime();
        for (int i = 0; i <= numberOfDays; i++)
        {
            tempDate = startDate.AddDays(i);
            if (tempDate.DayOfWeek != DayOfWeek.Saturday && tempDate.DayOfWeek != DayOfWeek.Sunday)
            {
                workingDays++;
            }
        }
        return workingDays;
    }

    static List<DateTime> GenerateRandomHolidays(DateTime startDate, DateTime endDate, int frequencyInMonth)
    {
        List<DateTime> holidays = new List<DateTime>();
        Random randomGenerator = new Random();
        DateTime randomDate = startDate;
        int numberOfMonths = (endDate - startDate).Days;
        for (int i = 0; i <= numberOfMonths; i++)
        {
            for (int j = frequencyInMonth; j > 0; j--)
            {
            randomDate = randomDate.AddDays(randomGenerator.Next(1, 31));
            randomDate = randomDate.AddMonths(i);
            holidays.Add(randomDate);
            }
        }

        return holidays;
    }

    static void Main()
    {
        DateTime endDate = GetEndDate();
        Console.WriteLine(endDate);
        int workingDays = CountWorkingDays(DateTime.Today, endDate);
        Console.WriteLine("There are {0} working days to the chosen date.", workingDays);
    }
}