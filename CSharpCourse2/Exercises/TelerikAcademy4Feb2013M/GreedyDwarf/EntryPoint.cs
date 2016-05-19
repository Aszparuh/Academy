namespace GreedyDwarf
{
    using System;
    using System.Linq;

    class EntryPoint
    {
        static void Main()
        {
            var separator = new char[] { ',' };
            var valley = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();

            int numberOfPatterns = int.Parse(Console.ReadLine());
            int[][] patterns = new int[numberOfPatterns][];

            for (int i = 0; i < numberOfPatterns; i++)
            {
                int[] pattern = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n)).ToArray();
                patterns[i] = pattern;
            }

            long maxCollectedCoins = long.MinValue;

            for (int i = 0; i < patterns.Length; i++)
            {
                var visited = new bool[valley.Length];
                var pattern = patterns[i];
                int positionOnValley = 0;
                int positionOnPattern = 0;
                long collectedCoins = 0;

                while ((0 <= positionOnValley && positionOnValley < valley.Length) && !visited[positionOnValley])
                {
                    collectedCoins += valley[positionOnValley];
                    visited[positionOnValley] = true;
                    if (collectedCoins > maxCollectedCoins)
                    {
                        maxCollectedCoins = collectedCoins;
                    }

                    positionOnValley += pattern[positionOnPattern];
                    positionOnPattern++;
                    if (positionOnPattern > pattern.Length - 1)
                    {
                        positionOnPattern = 0;
                    }
                }
            }

            Console.WriteLine(maxCollectedCoins);
        }
    }
}
