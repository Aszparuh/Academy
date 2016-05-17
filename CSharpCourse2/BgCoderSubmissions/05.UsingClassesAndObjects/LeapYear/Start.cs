namespace LeapYear
{
    using System;

    class Start
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            
            if (DateTime.IsLeapYear(input))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
