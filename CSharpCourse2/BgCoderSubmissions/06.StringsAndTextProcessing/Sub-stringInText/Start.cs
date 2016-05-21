namespace Sub_stringInText
{
    using System;

    class Start
    {
        static void Main()
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int position = 0;
            int postionCounter = 0;

            while (position < text.Length && (position = text.IndexOf(pattern, position)) != -1)
            {               
                position += pattern.Length;
                postionCounter++;
            }

            Console.WriteLine(postionCounter);
        }
    }
}
