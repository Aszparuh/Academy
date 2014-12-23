using System;
using System.IO;

/*Write a program that reads a text file and prints on
the console its odd lines.*/

class PrintOddLines
{
    static void WriteLines(string filePath, int numberOfLines)
    {
        StreamWriter writer = new StreamWriter(filePath);
        using (writer)
        {
            for (int i = 0; i <= numberOfLines; i++)
            {
                writer.WriteLine("Line Number {0}", i);
            }
        }

    }

    static void ReadOddLines(string FilePath, int numberOfLines)
    {
        StreamReader reader = new StreamReader(FilePath);
        using (reader)
        {
            for (int i = 0; i <= numberOfLines; i++)
            {
                reader.ReadLine();
                Console.WriteLine(reader.ReadLine());
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter number of lines: ");
        int numberOfLines = int.Parse(Console.ReadLine());
        string filePath = @"../../TextFiles/FileWithLines.txt";
        WriteLines(filePath, numberOfLines);
        ReadOddLines(filePath, numberOfLines);
    }
}