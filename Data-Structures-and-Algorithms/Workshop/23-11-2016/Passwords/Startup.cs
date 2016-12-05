using System;
using System.Collections.Generic;

namespace Passwords
{
    public class Startup
    {
        private static List<int[]> sequences;
        private static int passwordLength;
        private static string pattern;
        private static int passwordNumber;

        public static void Main()
        {
            passwordLength = int.Parse(Console.ReadLine());
            pattern = Console.ReadLine();
            passwordNumber = int.Parse(Console.ReadLine());
            Solve();

            foreach (var sequence in sequences)
            {
                Console.WriteLine(string.Join(",", sequence));
            }
        }

        private static void Solve()
        {
            sequences = new List<int[]>();
            if (pattern[0] == '<')
            {
                PutSmaller(new int[passwordLength], 0, 9);
            }
            else
            {
                PutBigger(new int[passwordLength], 0, 0);
            }
        }

        private static void PutBigger(int[] sequence, int index, int current)
        {
            if (index == passwordLength)
            {
                sequences.Add(sequence);
                return;
            }

            if (pattern[index] == '<')
            {
                PutSmaller(sequence, index, current);
            }

            for (int i = current + 1; i < 10; i++)
            {
                sequence[index] = i;
                PutBigger(sequence, index + 1, i);  
            }
        }

        private static void PutSmaller(int[] sequence, int index, int current)
        {
            if (index == passwordLength)
            {
                sequences.Add(sequence);
                return;
            }

            if (pattern[index] == '>')
            {
                PutBigger(sequence, index, current);
            }

            for (int i = current - 1; i < 0; i--)
            {
                sequence[index] = i;
                PutSmaller(sequence, index + 1, i);
            }
        }
    }
}
