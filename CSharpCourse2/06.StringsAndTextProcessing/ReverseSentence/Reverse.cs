namespace ReverseSentence
{
    using System;
    using System.Text;

    /*Write a program that reverses the words in given sentence.*/

    class Reverse
    {
        static string ReverseWords(string input)
        {
            string[] clause = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();
            for (int i = clause.Length - 1; i >= 0; i--)
            {
                sb.Append(clause[i]);
                if (i != 0)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.Write("Enter text: ");
            //string text = Console.ReadLine(); 
            string text = "C# is not C++, not PHP and not Delphi!";
            char lastSign = text[text.Length - 1];
            text = text.Remove(text.Length - 1, 1);
            string[] clauses = text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(clauses);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < clauses.Length; i++)
            {
                sb.Append(ReverseWords(clauses[i]));
                if (i != clauses.Length - 1)
                {
                    sb.Append(", ");
                }
            }

            sb.Append(lastSign);
            Console.WriteLine(sb);
        }
    }
}
