namespace CountOccurrencesText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

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

        private static Dictionary<string, int> CountOccurrencesText(string[] input)
        {
            var countedOccurrences = new Dictionary<string, int>();
            foreach (var item in input)
            {
                if (countedOccurrences.ContainsKey(item))
                {
                    countedOccurrences[item] += 1;
                }
                else
                {
                    countedOccurrences[item] = 1;
                }
            }

            return countedOccurrences;
        }

        private static void PrintSorted(Dictionary<string, int> dictionary)
        {
            var items = from pair in dictionary
                        orderby pair.Value ascending
                        select pair;

            foreach (var item in items)
            {
                Console.WriteLine("{0} => {1} times", item.Key, item.Value);
            }
        }

        public static void Main()
        {
            string path = @"../../test.txt";
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            var textFromFile = ReadFile(path);
            var lowerText = textFromFile.ToLower();
            var textAsArray = lowerText.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var allOccurrences = CountOccurrencesText(textAsArray);
            PrintSorted(allOccurrences);
        }
    }
}