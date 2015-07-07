namespace ConverterToString
{
    using System;

    class MainProgram
    {
        static void Main()
        {
            Converter newConverter = new Converter();
            Console.WriteLine(newConverter.ConvertBoolToString(true));
            Console.WriteLine(newConverter.ConvertBoolToString(false));
        }
    }
}