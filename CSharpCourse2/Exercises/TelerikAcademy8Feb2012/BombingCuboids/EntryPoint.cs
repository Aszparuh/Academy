namespace BombingCuboids
{
    using System;
    using System.Linq;

    class EntryPoint
    {
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


            }

            Console.WriteLine();
        }
    }
}
