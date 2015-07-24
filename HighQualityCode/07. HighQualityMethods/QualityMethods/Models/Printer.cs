namespace QualityMethods.Models
{
    using System;

    public static class Printer
    {
        public static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:F2}", number);
        }

        public static void PrintNumberAsPercentage(double number)
        {
            Console.WriteLine("{0:0.0%}", number);
        }

        public static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static void PrintDigitAsWord(int number)
        {
            string word = string.Empty;

            switch (number)
            {
                case 0: word = "zero";
                    break;
                case 1: word = "one";
                    break;
                case 2: word = "two";
                    break;
                case 3: word = "three";
                    break;
                case 4: word = "four";
                    break;
                case 5: word = "five";
                    break;
                case 6: word = "six";
                    break;
                case 7: word = "seven";
                    break;
                case 8: word = "eight";
                    break;
                case 9: word = "nine";
                    break;
                default: throw new ArgumentException("Number is not a digit");
            }

            Console.WriteLine(word);
        }
    }
}