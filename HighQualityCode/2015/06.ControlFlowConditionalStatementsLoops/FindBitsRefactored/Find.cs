namespace FindBitsRefactored
{
    using System;

    public class Find
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i++;
                count++;
            }

            return count;
        }

        public static void Main()
        {
            ///input
            int s = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string patternToSearch = Convert.ToString(s, 2).PadLeft(5, '0');
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                string numberAsBinaryString = Convert.ToString(currentNumber, 2).PadLeft(29, '0');
                counter += CountStringOccurrences(numberAsBinaryString, patternToSearch);
            }
            ////string numberAsString = Convert.ToString(n, 2).PadLeft(29, '0');
            Console.WriteLine(counter);
        }
    }
}
