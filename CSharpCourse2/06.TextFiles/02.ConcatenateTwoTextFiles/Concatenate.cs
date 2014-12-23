using System;
using System.IO;

/*Write a program that concatenates two text files
into another text file.*/

class Concatenate
{
    static string ReadFile(string filePath)
    {
        string content;
        StreamReader reader = new StreamReader(filePath);
        using (reader)
        {
            content = reader.ReadToEnd();
        }

        return content;
    }

    static void WriteFile(string content, string filePath)
    {
        StreamWriter writer = new StreamWriter(filePath, true);
        using (writer)
        {
            writer.Write(content);
        }
    }

    static void Main()
    {
        File.Delete(@"../../TextFiles/finalFile.txt");
        string inputPath = @"../../TextFiles/firstFile.txt";
        string outputPath = @"../../TextFiles/finalFile.txt";
        WriteFile(ReadFile(inputPath), outputPath);
        inputPath = @"../../TextFiles/secondFile.txt";
        WriteFile(ReadFile(inputPath), outputPath);

    }
}