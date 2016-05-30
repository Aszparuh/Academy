namespace BombingCuboids
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class EntryPoint
    {
        static Dictionary<char, int> charcters = new Dictionary<char, int>();

        static void Main()
        {
            string input = Console.ReadLine();
            var dimensions = input.Split(' ');

            int width = int.Parse(dimensions[0]);
            int height = int.Parse(dimensions[1]);
            int depth = int.Parse(dimensions[2]);

            char[,,] cuboid = new char[width, height, depth];

            for (int indexOnHeight = 0; indexOnHeight < cuboid.GetLength(1); indexOnHeight++)
            {
                string line = Console.ReadLine();
                var splitedLine = line.Split(' ');
                for (int indexOnDepth = 0; indexOnDepth < cuboid.GetLength(2); indexOnDepth++)
                {
                    for (int indexOnWidth = 0; indexOnWidth < cuboid.GetLength(0); indexOnWidth++)
                    {
                        cuboid[indexOnWidth, indexOnHeight, indexOnDepth] = splitedLine[indexOnDepth][indexOnWidth];
                    }
                }
            }

            int numberOfBombs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfBombs; i++)
            {
                var bombParameters = Console.ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
                int bombWidth = bombParameters[0];
                int bombHeight = bombParameters[1];
                int bombDepth = bombParameters[2];
                int bombPower = bombParameters[3];

                BombCuboid(bombWidth, bombHeight, bombDepth, bombPower, cuboid);
                AdjustFiledAfterBomb(cuboid);
            }

            foreach (var character in charcters)
            {
                Console.WriteLine(character.Key);
                Console.WriteLine(character.Value);
                Console.WriteLine();
            }
        }

        static void BombCuboid(int bombWidth, int bombHeight, int bombDepth, int bombPower, char[,,] cuboid)
        {
            for (int i = 0; i < cuboid.GetLength(0); i++)
            {
                for (int j = 0; j < cuboid.GetLength(1); j++)
                {
                    for (int k = 0; k < cuboid.GetLength(2); k++)
                    {
                        var distanceToBomb = Math.Round(Math.Sqrt(Math.Pow(i - bombWidth, 2) + Math.Pow(j - bombHeight, 2) + Math.Pow(k - bombDepth, 2)));
                        if (distanceToBomb <= bombPower)
                        {
                            char value = cuboid[i, j, k];
                            if (value != '0')
                            {
                                if (charcters.ContainsKey(value))
                                {
                                    charcters[value]++;
                                }
                                else
                                {
                                    charcters.Add(value, 1);
                                }
                            }
  
                            cuboid[i, j, k] = '0';
                        }
                    }
                }
            }
        }

        static void AdjustFiledAfterBomb(char[,,] cuboid)
        {
            for (int indexOnDepth = 0; indexOnDepth < cuboid.GetLength(2); indexOnDepth++)
            {
                for (int indexOnWidth = 0; indexOnWidth < cuboid.GetLength(0); indexOnWidth++)
                {
                    int index = cuboid.GetLength(1) - 1;
                    for (int indexOnHeight = cuboid.GetLength(1) - 1; indexOnHeight >= 0; indexOnHeight--)
                    {

                        if (cuboid[indexOnWidth, indexOnHeight, indexOnDepth] != '0')
                        {
                            char temp = cuboid[index, indexOnHeight, indexOnDepth];
                            cuboid[index, indexOnHeight, indexOnDepth] = cuboid[indexOnWidth, indexOnHeight, indexOnDepth];
                            cuboid[indexOnWidth, indexOnHeight, indexOnDepth] = temp;
                            index--;
                        }

                        //if (matrix[row, col] != ' ')
                        //{
                        //    char tmp = matrix[index, col];
                        //    matrix[index, col] = matrix[row, col];
                        //    matrix[row, col] = tmp;
                        //    index--;
                        //}
                    }
                }
            }
        }
    }
}
