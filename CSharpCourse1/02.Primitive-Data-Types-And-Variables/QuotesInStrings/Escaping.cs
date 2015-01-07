using System;

/*Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
Do the above in two different ways - with and without using quoted strings.
Print the variables to ensure that their value was correctly defined.*/

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