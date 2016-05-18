namespace KaspichanNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class EntryPoint
    {
        static void Main()
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string upperAlphabet = alphabet.ToUpper();
            List<string> generatedAlphabet = new List<string>();

            for (int i = 0; i < upperAlphabet.Length; i++)
            {
                generatedAlphabet.Add(upperAlphabet[i].ToString());
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < upperAlphabet.Length; j++)
                {
                    generatedAlphabet.Add(alphabet[i].ToString() + upperAlphabet[j]);
                }
            }

            Console.WriteLine(ConvertToKaspichan(number, generatedAlphabet));
        }

        static string ConvertToKaspichan(ulong number, List<string> alphabet)
        {
            string result = string.Empty;

            do
            {
                int index = (int)(number % 256);
                result = alphabet[index] + result;
                number = number / 256;
            } while (number > 0);

            return result;
        }
    }
}
