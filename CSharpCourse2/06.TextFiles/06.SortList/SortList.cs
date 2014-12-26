using System;
using System.IO;
using System.Collections.Generic;

/*Write a program that reads a text file containing a
list of strings, sorts them and saves them to another
text file. Example:
Ivan  George
Peter  Ivan
Maria  Maria
George  Peter*/

class SortList
{
    static List<string> GetStringArr(string inputPath)
    {
        List<string> listArr = new List<string>();
        StreamReader reader = new StreamReader(inputPath);
        using(reader)
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                listArr.Add(line);
            }
        }

        return listArr;
    }



    static void Main()
    {
        string inputPath = @"../../TextFiles/inputFile.txt";
        string outputPath = @"../../TextFile/outputFile.txt";
    }
}