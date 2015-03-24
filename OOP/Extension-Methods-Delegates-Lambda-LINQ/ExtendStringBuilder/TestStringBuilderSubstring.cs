namespace ExtendStringBuilder
{
    /*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the 
     * same functionality as Substring in the class String.*/
    using System;
    using System.Text;
    using ExtendStringBuilder.Extensions;

    class TestStringBuilderSubstring
    {
        static void Main()
        {
            var sb = new StringBuilder("Some text");
            Console.WriteLine(sb.Substring(5, 4));
        }
    }
}