namespace MovingLetters
{
    // 66/100 BgCoder 
    //have to use StringBulder for moving the letters right
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class EntryPoint
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            int maxLength = words.Max(w => w.Length);
            string preparedWords = CreateString(words, maxLength);
            //Console.WriteLine(preparedWords);
            var encrypted = Encrypt(preparedWords);
            Console.WriteLine(string.Join(string.Empty, encrypted));
        }

        static string CreateString(string[] words, int maxLength)
        {
            StringBuilder letters = new StringBuilder();
            for (int index = 0; index < maxLength; index++)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    int currentLetterIndex = words[i].Length - 1 - index;
                    if (currentLetterIndex >= 0)
                    {
                        letters.Append(words[i][currentLetterIndex]);
                    }
                }
            }

            return letters.ToString();
        }
        
        static List<char> Encrypt(string preparedWords)
        {
            List<char> list = new List<char>(preparedWords);

            for (int i = 0; i < list.Count; i++)
            {
                var letter = list[i];
                list.RemoveAt(i);
                int positionToBeMoved = (i + (char.ToLower(letter) - 96)) % (list.Count + 1);
                list.Insert(positionToBeMoved, letter);               
            }

            return list;
        }       
    }
}
