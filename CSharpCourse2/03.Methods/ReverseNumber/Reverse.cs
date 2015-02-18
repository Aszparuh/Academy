namespace ReverseNumber
{
    using System;
    using System.Text;

    /*Write a method that reverses the digits of given decimal number.
             Example:
             
             input	  output
             256	  652
             123.45	  54.321*/

    class Reverse
    {
        static string TakeInput()
        {
            Console.Write("Enter your number: ");
            return Console.ReadLine();
        }

        static string ReverseNumber()
        {
            string numberAsString = TakeInput();
            StringBuilder sb = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                sb.Append(numberAsString[i]);
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.WriteLine("Your number reversed is {0}", ReverseNumber());
        }
    }
}