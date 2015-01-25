using System;

/*A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer
time according to the definition above or invalid time if the time cannot be parsed*/

class CheckTime
{
    static void Main()
    {
        Console.Write("Enter time in “hh:mm tt” format: ");
        string timeAsString = Console.ReadLine();
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        DateTime inputTime;
        
        if (DateTime.TryParse(timeAsString, out inputTime))
        {
            DateTime after = DateTime.Parse("1:00 PM");
            DateTime before = DateTime.Parse("3:00 AM");
           
            if (inputTime >= after || inputTime < before)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("Invalid time");
        }
    }
}