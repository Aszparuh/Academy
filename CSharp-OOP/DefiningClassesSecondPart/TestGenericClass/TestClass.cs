namespace TestGenericClass
{
    using System;
    using GenericList;

    class TestClass
    {
        static void Main()
        {
            var list = new GenList<int>();

            for (int i = 1; i <= 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Print List");
            Console.WriteLine(string.Join(", ", list));

            list.InsertAt(3, 300);
            Console.WriteLine("Insert");
            Console.WriteLine(string.Join(", ", list));

            list.RemoveAt(3);
            Console.WriteLine("Remove");
            Console.WriteLine(string.Join(", ", list));

            Console.WriteLine("Find Min value");
            Console.WriteLine("Min value is {0}", list.Min());
        }
    }
}