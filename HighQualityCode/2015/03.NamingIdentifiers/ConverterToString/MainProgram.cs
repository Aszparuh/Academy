namespace ConverterToString
{
    using System;

    internal class MainProgram
    {
        internal static void Main()
        {
            Console.WriteLine(Converter.ConvertBoolToString(true));
            Console.WriteLine(Converter.ConvertBoolToString(false));
        }
    }
}