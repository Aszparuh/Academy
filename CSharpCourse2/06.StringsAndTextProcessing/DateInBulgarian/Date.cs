namespace DateInBulgarian
{
    using System;
    using System.Globalization;

    /*Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
     * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day 
     * of week in Bulgarian.*/

    class Date
    {
        static void Main()
        {
            Console.Write("Enter date in format day.month.year hour:minute:second: ");
            string dateString = Console.ReadLine();
            DateTime date;
            try
            {
                date = DateTime.ParseExact(dateString, "d.M.yyyy h:m:s", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format");
                return;
            }

            date = date.AddMinutes(30);
            date = date.AddHours(6);
            Console.WriteLine(date.ToString("d.M.yyyy h:m:s"));
            var culture = new System.Globalization.CultureInfo("bg-BG");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            Console.WriteLine(day);
        }
    }
}