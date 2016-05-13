namespace ReverseNumber
{
    using System;
    using System.Linq;

    class Start
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var result = new string(input.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
