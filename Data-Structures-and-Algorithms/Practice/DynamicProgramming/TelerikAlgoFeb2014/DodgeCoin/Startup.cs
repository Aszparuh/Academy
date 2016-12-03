using System;
using System.Linq;

namespace DodgeCoin
{
    public class Startup
    {
        private static void PrintMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void Main()
        {
            var nAndK = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var n = nAndK[0];
            var m = nAndK[1];

            var numberOfCoins = int.Parse(Console.ReadLine());
            var coinsCoordinates = new string[numberOfCoins];
            for (int i = 0; i < numberOfCoins; i++)
            {
                coinsCoordinates[i] = Console.ReadLine();
            }

            var field = new int[n, m];

            foreach (var coordinates in coinsCoordinates)
            {
                var xAndY = coordinates.Split(' ').Select(x => int.Parse(x)).ToArray();
                field[xAndY[0], xAndY[1]] += 1;
            }

            //PrintMatrix(field);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int candidate = 0;
                    if (i > 0)
                    {
                        candidate = field[i - 1, j];
                    }

                    if (j > 0)
                    {
                        candidate = Math.Max(candidate, field[i, j - 1]);
                    }

                    field[i, j] += candidate;
                }
            }

            //Console.WriteLine();
            //PrintMatrix(field);
            Console.WriteLine(field[n - 1, m - 1]);
        }
    }
}
