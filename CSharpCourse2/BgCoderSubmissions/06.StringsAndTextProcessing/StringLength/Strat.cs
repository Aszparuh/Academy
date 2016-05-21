namespace StringLength
{
    using System;
    using System.Text;

    class Strat
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                Console.WriteLine(FillWithAsterisks(input));
            }
            else
            {
                Console.WriteLine(input);
            }
        }

        static string FillWithAsterisks(string anyString)
        {
            anyString = anyString.Replace(@"\", string.Empty);
            StringBuilder sb = new StringBuilder(anyString);

            while (sb.Length < 20)
            {
                sb.Append("*");
            }

            return sb.ToString();
        }
    }
}
