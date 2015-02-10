namespace ParseTags
{
    using System;
    using System.Text;

    /*You are given a text. Write a program that changes the text in all regions surrounded by the 
     * tags <upcase> and </upcase> to upper-case. The tags cannot be nested.*/

    class Parse
    {
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

        static void Main()
        {
            Console.Write("Enter the text: ");
            //string text = Console.ReadLine();
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else."
            Console.WriteLine(ToUpperCase(text));
        }
    }
}