namespace ParseTags
{
    using System;
    using System.Text;

    class Start
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ToUpperCase(input));
        }

        static string ToUpperCase(string input)
        {
            string openTag = "<upcase>";
            string closeTag = "</upcase>";
            string empty = string.Empty;
            StringBuilder sb = new StringBuilder(input);
            int position = 0;

            while ((position = input.IndexOf(openTag, position)) != -1)
            {
                position += 8;
                int startPos = position;
                int endPos = input.IndexOf(closeTag, startPos);

                for (int i = startPos; i <= endPos; i++)
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }

            sb.Replace(openTag, empty);
            sb.Replace(closeTag, empty);

            return sb.ToString();
        }

    }
}
