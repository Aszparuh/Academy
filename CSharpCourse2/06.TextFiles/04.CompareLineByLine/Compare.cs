using System;
using System.IO;

/*Write a program that compares two text files line by
line and prints the number of lines that are the same
and the number of lines that are different. Assume
the files have equal number of lines.*/

class Compare
{
    static void CompareFiles(string firstFile, string secondFile)
    {
        int identicalLines = 0;
        int diffLines = 0;
        using (StreamReader firstFileReader = new StreamReader(firstFile))
        {
            using (StreamReader secondFileReader = new StreamReader(secondFile))
            {
                string firstFileLine = string.Empty;
                while ((firstFileLine = firstFileReader.ReadLine()) != null) //Assume equal number of lines
                {
                    string secondFileLine = secondFileReader.ReadLine();
                    if (firstFileLine == secondFileLine)
                    {
                        identicalLines++;
                    }
                    else
                    {
                        diffLines++;
                    }
                }
            }
        }
        Console.WriteLine("Number of identical lines: {0}", identicalLines);
        Console.WriteLine("Number of different lines: {0}", diffLines);
        //There are 2 different lines in the files.
        //number of lines 24.
    }

    static void Main()
    {
        string firstFilePath = @"../../TextFiles/textFile.txt";
        string secondFilePath = @"../../TextFiles/anotherTextFile.txt";
        CompareFiles(firstFilePath, secondFilePath);
    }
}