using System;
using System.Collections.Generic;
using System.IO;

/*Write a program that extracts from given XML file
all the text without the tags.*/

class RemoveTags
{
    static string RemoveTags(string line)
    {
        string lineWithoutTags;
        int startPos = 0;
        int endPos = 0;
        for (int i = 0; i < line.Length; i++)
        {
            
        }
    }

    static List<string> ReadLine(string filePath)
    {
        List<string> textWithoutTags = new List<string>();
        StreamReader reader = new StreamReader(filePath);
        using (reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                
            }
        }
    }

    static void Main()
    {
        string filePath = @"../../TextFiles/textTags.txt";
    }
}