using System;
using System.IO;

/*Write a program that replaces all occurrences of the
substring "start" with the substring "finish" in a text
file. Ensure it will work with large files (e.g. 100 MB).*/

class ReplaceSubstring
{
    static void Replace(string inputPath, string outputPath)
    {
        using (StreamReader reader = new StreamReader(inputPath))
        {
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.Replace("start", "finish"));
                }
            }
        }
    }

    static void Main()
    {
        string inputPath = @"../../TextFiles/inputFile.txt";
        string outputPath = @"../../TextFiles/outputFile.txt";
        Replace(inputPath, outputPath);
    }
}