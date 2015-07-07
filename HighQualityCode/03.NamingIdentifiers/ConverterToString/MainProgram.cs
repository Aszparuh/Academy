namespace ConverterToString
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Console.WriteLine(Converter.ConvertBoolToString(true));
            Console.WriteLine(Converter.ConvertBoolToString(false));
        }
    }
}