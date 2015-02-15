namespace FormatNumber
{
    using System;

    /*Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
      percentage and in scientific notation.
      Format the output aligned right in 15 symbols.*/

    class Format
    {
        static void FormatString(int num)
        {
            string template = "{0, -15} {1,15}";
            Console.WriteLine(string.Format(template,"Decimal" ,num));
            Console.WriteLine(string.Format(template,"Hexadecimal" , num.ToString("X")));
            Console.WriteLine(string.Format(template,"Percentage" , num.ToString("P0")));
            Console.WriteLine(string.Format(template,"Scientific" , num.ToString("E")));
        }

        static void Main()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());
            FormatString(number);
        }
    }
}