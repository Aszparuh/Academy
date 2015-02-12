namespace UnicodeCharacters
{
    using System;
    using System.Text;

    /*Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.
    Example:

    input	output
    Hi!	\u0048\u0069\u0021*/

    class ConvertToUnicodeLiterals
    {
        static string Convert(string input)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string template = "\\u{0}";
                sb.Append(string.Format(template, ((int)input[i]).ToString("X4")));
            }

            return sb.ToString();
        }
        static void Main()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();

            Console.WriteLine(Convert(text));
        }
    }
}