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

    static List<string> SortElements(List<string> anyStringList)
    {
        for (int i = 0; i < anyStringList.Count - 1; i++)
        {
            for (int j = i + 1; j < anyStringList.Count; j++)
            {
                if (char.ToUpper(anyStringList[i][0]) > char.ToUpper(anyStringList[j][0])) //ignore the case of the char
                {
                    string temp = anyStringList[i];
                    anyStringList[i] = anyStringList[j];
                    anyStringList[j] = temp;
                }
            }
        }

        return anyStringList;
    }

    static void WriteResult(List<string> resultList, string path)
    {
        StreamWriter writer = new StreamWriter(path);
        using (writer)
        {
            for (int i = 0; i < resultList.Count; i++)
            {
                writer.WriteLine(resultList[i]);
            }
        }
    }

    static void Main()
    {
        string inputPath = @"../../TextFiles/inputFile.txt";
        string outputPath = @"../../TextFiles/outputFile.txt";
        List<string> listToSort = GetStringArr(inputPath);
        WriteResult(SortElements(listToSort), outputPath);
    }
}