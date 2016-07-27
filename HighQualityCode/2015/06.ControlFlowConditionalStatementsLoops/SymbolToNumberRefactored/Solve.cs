namespace SymbolToNumberRefactored
{
    using System;

    public class Solve
    {
        public static void PrintAndCalculate(int currentNumber, int position)
        {
            if (position % 2 == 0)
            {
                Console.WriteLine("{0:0.00}", (double)currentNumber / 100);
            }
            else
            {
                Console.WriteLine("{0}", currentNumber * 100);
            }
        }

        public static void Main()
        {
            ////intput
            int secret = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int length = text.Length;
            ////logic
            for (int i = 0; i < length; i++)
            {
                if (text[i] == '@')
                {
                    break;
                }

                if (char.IsDigit(text[i]))
                {
                    int currentNumber = (int)text[i] + secret + 500;
                    PrintAndCalculate(currentNumber, i);
                }
                else if (char.IsLetter(text[i]))
                {
                    int currentNumber = ((int)text[i] * secret) + 1000;
                    PrintAndCalculate(currentNumber, i);
                }
                else
                {
                    int currentNumber = (int)text[i] - secret;
                    PrintAndCalculate(currentNumber, i);
                }
            }
        }
    }
}
