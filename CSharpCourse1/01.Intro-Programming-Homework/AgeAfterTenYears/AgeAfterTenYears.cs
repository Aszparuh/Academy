using System;

/*Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.*/

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDate = new DateTime();
        Console.Write("Enter birth year: ");
        birthDate = birthDate.AddYears(int.Parse(Console.ReadLine()) - 1);
        Console.Write("Enter birth month: ");
        birthDate = birthDate.AddMonths(int.Parse(Console.ReadLine()) - 1);
        Console.Write("Enter birth day: ");
        birthDate = birthDate.AddDays(int.Parse(Console.ReadLine()) - 1);

        DateTime today = DateTime.Today;

        //Calculate age today
        int age;
        age = today.Year - birthDate.Year;
        if (age > 0)
        {
            age -= Convert.ToInt32(today.Date < birthDate.Date.AddYears(age));
        }
        else
        {
            Console.WriteLine("Error");
        }
        Console.WriteLine("You are {0} years old.",age);

        //Calculate age in ten years
        today = today.AddYears(10);

        age = today.Year - birthDate.Year;
        if (age > 0)
        {
            age -= Convert.ToInt32(today.Date < birthDate.Date.AddYears(age));
        }
        else
        {
            Console.WriteLine("Error");
        }
        Console.WriteLine("In ten years you will be {0} years old",age);
    }
}