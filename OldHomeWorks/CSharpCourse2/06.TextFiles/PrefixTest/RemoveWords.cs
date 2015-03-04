using System;
using System.IO;

/*Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.*/

class RemoveWords
{
    static void Main()
    {
        const string searchTerm = "test";
        StreamReader reader = null;
        try
        {
            reader = new StreamReader(@"../../TextFiles/sample.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Input file not found.");
            return;
        }
        StreamWriter writer = null;
        try
        {
            writer = new StreamWriter(@"../../TextFiles/test_removed.txt");
        }
        catch (IOException)
        {
            Console.WriteLine("Cannot create output file.");
            return;
        }
        string s;
        string[] words;
        int removedWords = 0;
        int totalWords = 0;
        using (reader)
        using (writer)
        {
            s = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                words = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    totalWords++;
                    if (!words[i].StartsWith(searchTerm))
                        writer.Write(words[i] + " ");
                    else
                        removedWords++;
                }
                writer.WriteLine();
                s = reader.ReadLine();
            }
        }

        Console.WriteLine("Task complete. Output file created. {0} words removed.", removedWords);
        Console.WriteLine("Processed words: {0}", totalWords);
    }
}