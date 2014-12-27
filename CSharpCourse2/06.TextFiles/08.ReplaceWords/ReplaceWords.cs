using System;
using System.IO;
using System.Text.RegularExpressions;

/*Modify the solution of the previous problem to
replace only whole words (not substrings).*/

class ReplaceWords
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
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
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

