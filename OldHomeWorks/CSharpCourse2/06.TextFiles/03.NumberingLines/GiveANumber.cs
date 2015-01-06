using System;
using System.IO;

/*Write a program that reads a text file and inserts line
numbers in front of each of its lines. The result
should be written to another text file.*/

class GiveANumber
{
    static void NumberLines(string inputFile, string outputFile)
    {
        StreamReader reader = new StreamReader(inputFile);
        StreamWriter writer = new StreamWriter(outputFile);
        using (reader)
        {
            using (writer)
            {
                string line;
                int lineNumber = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(lineNumber + ". " + line);
                    lineNumber++;
                }
            }
        }
    }

    static void Main()
    {
        string inputFilePath = @"../../TextFiles/inputFile.txt";
        string outputFilePath = @"../../TextFiles/outputFile.txt";
        NumberLines(inputFilePath, outputFilePath);
    }
}