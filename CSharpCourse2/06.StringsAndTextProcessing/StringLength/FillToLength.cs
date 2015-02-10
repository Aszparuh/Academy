namespace StringLength
{
    using System;
    using System.Text;

    /*Write a program that reads from the console a string of maximum 20 characters. 
     If the length of the string is less than 20, the rest of the characters should be filled with *.
     Print the result string into the console.*/

    class FillToLength
    {
        static string GetInput()
        {
            Console.Write("Enter string up to twenty characters: ");
            string input = Console.ReadLine();
            if (input.Length > 20)
            {
                throw new FormatException("Length is greater than 20");
            }
            else
            {
                return input;
            }
        }

        static string FillWithAsterisks(string anyString)
        {
            StringBuilder sb = new StringBuilder(anyString);

            while (sb.Length < 20)
            {
                sb.Append("*");
            }

            return sb.ToString();
        }

        static void Main()
        {
            try
            {
                string input = GetInput();
                Console.WriteLine(FillWithAsterisks(input));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Invalid format");
            } 
        }
    }
}