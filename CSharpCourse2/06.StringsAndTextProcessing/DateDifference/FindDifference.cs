namespace DateDifference
{
    using System;
    using System.Globalization;

    /*Write a program that reads two dates in the format: day.month.year and 
     * calculates the number of days between them.*/

    class FindDifference
    {
        static void Main()
        {
            Console.Write("Enter first date in format 'day.month.year': ");
            string strFirstDate = Console.ReadLine();
            Console.Write("Enter second date in format 'day.month.year': ");
            string strSecDate = Console.ReadLine();
            DateTime firstDate;
            DateTime secondDate;
            try
            {

                firstDate = DateTime.ParseExact(strFirstDate, "d.M.yyyy", CultureInfo.InvariantCulture);
                secondDate = DateTime.ParseExact(strSecDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unrecognised format.");
                return;
            }

            Console.WriteLine("There is {0} days between {1} and {2}", (secondDate - firstDate).Days, firstDate.ToShortDateString(), secondDate.ToShortDateString());
        }
    }
}