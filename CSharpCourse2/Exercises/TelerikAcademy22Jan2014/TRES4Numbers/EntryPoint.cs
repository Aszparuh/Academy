namespace TRES4Numbers
{
    using System;
    using System.Numerics;

    class EntryPoint
    {
        static string[] alphabet = new string[]
        {
            "LON+",
            "VK-",
            "*ACAD",
            "^MIM",
            "ERIK|",
            "SEY&",
            "EMY>>",
            "/TEL",
            "<<DON"
        };

        static string Convert(BigInteger input)
        { 
            string result = string.Empty;

            do
            {
                int digit = (int)(input % 9);
                result = alphabet[digit].ToString() + result;
                input = input / 9;
            } while (input != 0);

            return result;
        }

        

        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(Convert(BigInteger.Parse(input)));
        }
    }
}
