using System;

class TwoStringsObject
{
    static void Main()
    {
        string helloStr = "Hello!";
        string worldStr = "World";
        object concatenation = helloStr + " " + worldStr;

        Console.WriteLine(concatenation);

        string result = concatenation.ToString();

        Console.WriteLine(result);
    }
}

