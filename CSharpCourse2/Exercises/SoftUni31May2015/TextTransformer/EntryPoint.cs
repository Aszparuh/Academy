namespace TextTransformer
{
    //80/100 SoftUni Judge
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class EntryPoint
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder resultSb = new StringBuilder();
            string line = Console.ReadLine();
            while (line != "burp")
            {
                sb.Append(Regex.Replace(line, @"\s+", " "));
                line = Console.ReadLine();
            }

            string text = sb.ToString();
            char dollar = '$';
            char percent = '%';
            char ampersand = '&';
            char quote = '\'';

            bool inDollarString = false;
            bool inPercentString = false;
            bool inAmpersandString = false;
            bool inQuoteString = false;
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == dollar && inDollarString)
                {
                    inDollarString = false;
                    resultSb.Append(' ');
                }
                else if (text[i] == dollar && !inDollarString && text.IndexOf(dollar, i + 1) != -1)
                {
                    inDollarString = true;
                    counter = 0;
                }

                if (text[i] == percent && inPercentString)
                {
                    inPercentString = false;
                    resultSb.Append(' ');
                }
                else if (text[i] == percent && !inPercentString && text.IndexOf(percent, i + 1) != -1)
                {
                    inPercentString = true;
                    counter = 0;
                }

                if (text[i] == ampersand && inAmpersandString)
                {
                    inAmpersandString = false;
                    resultSb.Append(' ');
                }
                else if (text[i] == ampersand && !inAmpersandString && text.IndexOf(ampersand, i + 1) != -1)
                {
                    inAmpersandString = true;
                    counter = 0;
                }

                if (text[i] == quote && inQuoteString)
                {
                    inQuoteString = false;
                    resultSb.Append(' ');
                }
                else if (text[i] == quote && !inQuoteString && text.IndexOf(quote, i + 1) != -1)
                {
                    inQuoteString = true;
                    counter = 0;
                }

                if (inDollarString && text[i] != dollar)
                {
                    if (counter % 2 == 0)
                    {
                        resultSb.Append((char)(text[i] + 1));
                        counter++;
                    }
                    else
                    {
                        resultSb.Append((char)(text[i] - 1));
                        counter++;
                    }
                }

                if (inPercentString && text[i] != percent)
                {
                    if (counter % 2 == 0)
                    {
                        resultSb.Append((char)(text[i] + 2));
                        counter++;
                    }
                    else
                    {
                        resultSb.Append((char)(text[i] - 2));
                        counter++;
                    }
                }

                if (inAmpersandString && text[i] != ampersand)
                {
                    if (counter % 2 == 0)
                    {
                        resultSb.Append((char)(text[i] + 3));
                        counter++;
                    }
                    else
                    {
                        resultSb.Append((char)(text[i] - 3));
                        counter++;
                    }
                }

                if (inQuoteString && text[i] != quote)
                {
                    if (counter % 2 == 0)
                    {
                        resultSb.Append((char)(text[i] + 4));
                        counter++;
                    }
                    else
                    {
                        resultSb.Append((char)(text[i] - 4));
                        counter++;
                    }
                }
            }

            Console.WriteLine(resultSb.ToString().Trim());
        }
    }
}
