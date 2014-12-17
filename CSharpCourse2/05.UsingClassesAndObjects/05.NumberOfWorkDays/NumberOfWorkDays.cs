using System;

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

    static void Main()
    {
        DateTime endDate = GetEndDate();
        Console.WriteLine(endDate);
    }
}