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
        }
    }
}