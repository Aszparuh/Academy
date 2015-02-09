namespace CorrectBrackets
{
    /*Write a program to check if in a given expression the brackets are put correctly.*/

    using System;

    class CheckBrackets
    {
        static int Check(string expr)
        {
            int balance = 0;

            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    balance++;
                }
                if (expr[i] == ')')
                {
                    balance--;
                }
            }

            return balance;
        }

        static void Main()
        {
            Console.Write("Enter expression with brackets: ");
            string expression = Console.ReadLine();
            int balance = Check(expression);

            if (balance == 0)
            {
                Console.WriteLine("The brackets are correct");
            }
            else
            {
                Console.WriteLine("The brackets are not correct");
            }
        }
    }
}