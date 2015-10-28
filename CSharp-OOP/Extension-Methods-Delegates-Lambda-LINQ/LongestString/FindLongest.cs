namespace LongestString
{
    /*Write a program to return the string with maximum length from an array of strings.
      Use LINQ.*/
    using System;
    using System.Linq;
 
    class FindLongest
    {
        static void Main()
        {
            string[] arr = 
            {
                "Write", 
                "a", 
                "program",
                "to",
                "return",
                "the",
                "string",
                "with",
                "maximum",
                "length",
                "from",
                "an",
                "array",
                "of", 
                "strings"
            };

            //var longest = list.OrderByDescending(s => s.Length)
            //       .ThenBy(s => s)
            //       .FirstOrDefault();
            var longest =
                from str in arr
                orderby str.Length descending
                select str;
            var longestLenght = longest.First().Length;
            foreach (var str in longest)
            {
                if (str.Length == longestLenght)
                {
                    Console.WriteLine(str);
                }
            }

        }
    }
}