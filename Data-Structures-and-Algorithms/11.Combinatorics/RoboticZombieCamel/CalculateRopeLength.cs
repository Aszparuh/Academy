namespace RoboticZombieCamel
{
    using System;
    using System.Collections.Generic;

    public class CalculateRopeLength
    {
        private static int length = 0;
        public static void Main()
        {
            //Get the input;
            int numberOfObelisc = int.Parse(Console.ReadLine());
            var allObeliscs = new List<Obelisc>();

            for (int i = 0; i < numberOfObelisc; i++)
            {
                string line = Console.ReadLine();
                var allNumbersOnLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int currentX = int.Parse(allNumbersOnLine[0]);
                int currentY = int.Parse(allNumbersOnLine[1]);
                var currentObelisc = new Obelisc(currentX, currentY);
                allObeliscs.Add(currentObelisc);
            }

            GetRopeLength(numberOfObelisc, allObeliscs);
            Console.WriteLine(length);
        }

        private static void GetRopeLength(int numberOfObelisc, List<Obelisc> allObeliscs)
        {
            for (int k = 1; k <= allObeliscs.Count; k++)
            {
                GenerateCombinationsWithoutRepetition(0, 0, allObeliscs, k, length);
            }
        }

        private static void GenerateCombinationsWithoutRepetition(int index, int start, List<Obelisc> obelsics, int numberOfElements, int length)
        {
            if (index > numberOfElements)
            {
                return;
            }
            else
            {
                for (int i = start; i < numberOfElements; i++)
                {
                    length += obelsics[i].DistanceToCenter();
                    GenerateCombinationsWithoutRepetition(index + 1, i, obelsics, numberOfElements, length);
                    //length -= obelsics[i].DistanceToCenter();
                }
            }
        }
    }

    public class Obelisc
    {
        public Obelisc(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int DistanceToCenter()
        {
            return this.X + this.Y;
        }
    }
}