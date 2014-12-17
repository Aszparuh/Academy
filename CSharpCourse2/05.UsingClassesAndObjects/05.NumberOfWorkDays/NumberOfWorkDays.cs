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

    static int RemoveWeekends(DateTime startDate, DateTime endDate)
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

    static int RemoveHolidays(DateTime startDate, DateTime endDate, int daysWithoutWeekends, List<DateTime> holidays)
    {
        int numberOfDays = (endDate - startDate).Days;
        DateTime tempDate = new DateTime();
        for (int i = 0; i < numberOfDays; i++)
        {
            tempDate = startDate.AddDays(i);
            for (int j = 0; j < holidays.Count; j++)
            {
                if (tempDate == holidays[j] && holidays[j].DayOfWeek != DayOfWeek.Saturday && holidays[j].DayOfWeek != DayOfWeek.Sunday)
                {
                    daysWithoutWeekends--;
                }
            }
        }
        return daysWithoutWeekends;
    }

    static List<DateTime> GenerateRandomHolidays(DateTime startDate, DateTime endDate, int frequencyInMonth)
    {
        List<DateTime> holidays = new List<DateTime>();
        Random randomGenerator = new Random();
        DateTime randomDate = new DateTime(startDate.Year, startDate.Month, 1);
        int numberOfMonths = ((endDate.Year - startDate.Year) * 12) + endDate.Month - startDate.Month;
        for (int i = 0; i < numberOfMonths; i++)
        {
            for (int j = frequencyInMonth; j > 0; j--)
            {
                DateTime startOfEveryMont = new DateTime(randomDate.Year, randomDate.Month, 1);
                randomDate = startOfEveryMont.AddDays(randomGenerator.Next(0, 30));
                holidays.Add(randomDate);
            }
            randomDate = randomDate.AddMonths(1);
        }

        return holidays;
    }

    static void Main()
    {
        DateTime endDate = GetEndDate();
        Console.Write("Enter frequency of holidays per month: ");
        int holidaysPerMonth = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Holidays are ranodmly generated");
        List<DateTime> holidays = GenerateRandomHolidays(DateTime.Today, endDate, holidaysPerMonth);
        int daysWithoutWeekends = RemoveWeekends(DateTime.Today, endDate);
        int workingDays = RemoveHolidays(DateTime.Today, endDate, daysWithoutWeekends, holidays);
        Console.WriteLine("There are {0} working days to the chosen date.", workingDays);
    }
}