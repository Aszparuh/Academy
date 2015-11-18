namespace RoboticZombieCamel
{
    using System;

    public class CalculateRopeLength
    {
        public static void Main()
        {
            char[] separators = new char[] { ' ' };
            int numberOfObeliscs = int.Parse(Console.ReadLine());
            int[] distancesToCenter = new int[numberOfObeliscs];

            for (int i = 0; i < numberOfObeliscs; i++)
            {
                string line = Console.ReadLine();
                var splitedLine = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int x = Math.Abs(int.Parse(splitedLine[0]));
                int y = Math.Abs(int.Parse(splitedLine[1]));

                distancesToCenter[i] = x + y;
            }

            int repetitions = (int)Math.Pow(2, numberOfObeliscs - 1);
            ulong sum = 0;

            for (int i = 0; i < numberOfObeliscs; i++)
            {
                sum += (ulong)distancesToCenter[i] * (ulong)repetitions;
                sum %= ulong.MaxValue;
            }

            Console.WriteLine(sum);
        }
    }
}