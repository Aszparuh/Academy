using System;
class Escaping
{
    static void Main()
    {
        string quotes = "The \"use\" of quotations causes difficulties.";
        string quotes1 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(quotes);
        Console.WriteLine(quotes1);
    }
}

