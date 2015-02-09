namespace CorrectBrackets
{
    /*Write a program to check if in a given expression the brackets are put correctly.*/

    using System;

    class CheckBrackets
    {
        static bool Check(string expr)
        {
            bool emptyBrackets = false;
            bool inBrackets = false;
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    inBrackets = true;
                }
                if (expr[i] == ')')
                {
                    if (inBrackets)
                    {
                        inBrackets = false;  
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (!inBrackets)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main()
        {
            Console.Write("Enter expression with brackets: ");
            string expression = Console.ReadLine();
            Console.WriteLine(Check(expression));
        }
    }
}