namespace CorrectBrackets
{
    using System;

    class Start
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int openBracketCount = 0;
            int closeBracketCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openBracketCount++;
                }

                if (input[i] == ')')
                {
                    closeBracketCount++;
                }
            }

            if (closeBracketCount == openBracketCount)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
