using System;
using System.Collections.Generic;
using System.IO;

/*Write a program that deletes from given text file all
odd lines. The result should be in the same file.*/

class DeleteOddLines
{
    static List<string> GetEvenLines(string path)
    {
        List<string> evenLines = new List<string>();
        int lineNumber = 1;
        StreamReader reader = new StreamReader(path);
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (lineNumber % 2 == 0)
                {
                    evenLines.Add(line);
                }

                lineNumber++;
            }
        }

        return evenLines;
    }

    static void WriteEvenLines(List<string> evenLines, string path)
    {
        StreamWriter writer = new StreamWriter(path);
        using (writer)
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.WriteLine(evenLines[i]);
            }
        }
    }

    static void Main()
    {
        string filePath = @"../../TextFiles/inputFile.txt";
        WriteEvenLines(GetEvenLines(filePath), filePath);
    }
}