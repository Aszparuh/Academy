namespace EncodeDecode
{
    using System;
    using System.Text;

    /*Write a program that encodes and decodes a string using given encryption key (cipher).
      The key consists of a sequence of characters.
      The encoding/decoding is done by performing XOR (exclusive or) operation over the 
      first letter of the string with the first of the key, the second – with the second, 
      etc. When the last key character is reached, the next is the first.*/

    class Code
    {
        static string Encrypt(string text, string key)
        {
            StringBuilder sb = new StringBuilder();
            int keyPosition = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (keyPosition == key.Length)
                {
                    keyPosition = 0;
                }

                sb.Append((char)((int)text[i] ^ (int)key[keyPosition]));
                keyPosition++;
            }

            return sb.ToString();
        }

        static void Main()
        {
            Console.Write("Enter string to encrypt: ");
            string text = Console.ReadLine();
            Console.Write("Enter your encryption key: ");
            string key = Console.ReadLine();

            string encrypted = Encrypt(text, key);
            Console.WriteLine(@"Encrypted text ""{0}"" - some characters can't be printed.", encrypted);
            string decrypted = Encrypt(encrypted, key);
            Console.WriteLine(@"Decrypted text ""{0}"" ", decrypted);
            
        }
    }
}
