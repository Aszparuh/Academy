using System;
using System.Collections.Generic;
using System.IO;

/*Write a program that extracts from given XML file
all the text without the tags.*/

class RemoveTags
{
    static void Main()
    {
        string s;
        int closedBrackedPos = 0;
        int openBrackedPos = 0;
        try
        {

            using (StreamReader sr = new StreamReader("../../TextFiles/textTags.txt"))
            {
                while (!sr.EndOfStream)
                {
                    closedBrackedPos = 0;
                    openBrackedPos = 0;
                    s = sr.ReadLine().Trim();
                    while (!s.EndsWith(">"))
                    {
                        s = s + " " + sr.ReadLine().Trim(); 
                    }

                    closedBrackedPos = s.IndexOf('>');
                    while (closedBrackedPos > -1 && closedBrackedPos < s.Length - 1)
                    {
                        openBrackedPos = s.IndexOf('<', closedBrackedPos + 1);
                        if (s[closedBrackedPos + 1] != '<')
                        {
                            Console.WriteLine(s.Substring(closedBrackedPos + 1, openBrackedPos - closedBrackedPos - 1));
                            Console.WriteLine(new string('-', 50));
                        }
                        s = s.Substring(openBrackedPos);
                        closedBrackedPos = s.IndexOf('>');
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Cannot fint input file.");
            return;
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("ERROR!!!. Wrong file format.");
        }
    }
}