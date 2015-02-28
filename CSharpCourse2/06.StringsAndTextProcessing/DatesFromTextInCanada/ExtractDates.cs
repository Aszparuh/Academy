namespace DatesFromTextInCanada
{
    using System;
    using System.Globalization;
    using System.Threading;

    /*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
      Display them in the standard date format for Canada.*/

    class ExtractDates
    {
        static void Main()
        {
            string text = "Revolution is an American post-apocalyptic science fiction television series that ran from 17.11.2012 until 21.06.2014";
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i].TrimEnd(new char[] { ',', '.', '!', '?' }), "d.M.yyyy", CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.Write("Canada english: {0}", date.Date.ToLongDateString());
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("fr-CA");
                    Console.WriteLine(" \t Canada french: {0}", date.Date.ToLongDateString());
                }

                catch (FormatException)
                {
                }
            }
        }
    }
}