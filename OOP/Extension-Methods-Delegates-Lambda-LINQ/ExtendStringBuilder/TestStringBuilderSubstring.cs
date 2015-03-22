namespace ExtendStringBuilder
{
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