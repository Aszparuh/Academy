namespace InvalidRangeException
{
    using System;
    using System.Globalization;

    class TestException
    {
        static void Main()
        {
            int chosenNumber = int.Parse(Console.ReadLine());

            if (chosenNumber < 1 || chosenNumber > 100)
            {
                throw new InvalidRangeException<int>(string.Format("Number is not in the range [{0}..{1}]",1,100), 1, 100);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>(string.Format("Date must be in range {0} - {1}", startDate, endDate), startDate, endDate);
            }
        }
    }
}