namespace CompareCharArrays
{
    using System;

    class Start
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            if (string.Compare(first, second) < 0)
            {
                Console.WriteLine("<");
            }
            else if (string.Compare(first, second) > 0)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("=");
            }
        }
    }
}
