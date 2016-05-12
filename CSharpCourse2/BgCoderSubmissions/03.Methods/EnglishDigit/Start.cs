namespace EnglishDigit
{
    using System;

    class Start
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintWord(GetLastDigit(input)));
        }

        static int GetLastDigit(int number)
        {
            return number % 10;
        }

        static string PrintWord(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "error";
            }
        }
    }
}
