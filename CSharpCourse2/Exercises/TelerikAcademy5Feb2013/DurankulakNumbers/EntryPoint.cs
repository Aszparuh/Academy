namespace DurankulakNumbers
{
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> alphabet = new List<string>();

            for (char i = 'A'; i <= 'Z'; i++)
            {
                alphabet.Add(i.ToString());
            }

            for (char i = 'a'; i <= 'f'; i++)
            {
                if (i == 'f')
                {
                    for (char j = 'A'; j <= 'L'; j++)
                    {
                        alphabet.Add(i + j.ToString());
                    }
                }
                else
                {
                    for (char j = 'A'; j <= 'Z'; j++)
                    {
                        alphabet.Add(i + j.ToString());
                    }
                }
            }

            //foreach (var word in alphabet)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.WriteLine(alphabet.Count);

            Console.WriteLine(ConvertToDurankulak(input, alphabet));
        }

        static long ConvertToDurankulak(string input, List<string> alphabet)
        {
            long result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]))
                {
                    string word = input.Substring(i, 2);
                    i++;
                    result = alphabet.IndexOf(word) + result * 168;
                }
                else
                {
                    result = alphabet.IndexOf(input[i].ToString()) + result * 168;
                }
            }

            return result;
        }
    }
}
