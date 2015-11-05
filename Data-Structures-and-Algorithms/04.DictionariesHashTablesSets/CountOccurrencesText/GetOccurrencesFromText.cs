namespace CountOccurrencesText
{
    using System;
    using System.IO;
    using System.Collections.Generic;

    public class GetOccurrencesFromText
    {
        private static string ReadFile(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string allText = reader.ReadToEnd();
                    return allText;
                }
            }
            catch (Exception e)
            {
                throw new ArgumentException("Can't read file");
            }
        }

        private static Dictionary<string, int> CountOccurrencesText(string text)
        {

        }

        public static void Main()
        {
            string path = @"../../test.txt";
            string textFromFile = ReadFile(path);
            
        }
    }
}