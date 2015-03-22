namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using IEnumerableExtensions.Extensions;

    class TestIEnumerableExtensions
    {
        static void Main()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var list2 = new List<string> { "aa", "bb", "cc" };
            Console.WriteLine("Sum is {0}", list.Sum());
            Console.WriteLine("Product is {0}", list.Product());
            Console.WriteLine("Average is {0}", list.Average());
            Console.WriteLine("Min is {0}", list.Min());
            Console.WriteLine("Max is {0}", list.Max());
        }
    }
}