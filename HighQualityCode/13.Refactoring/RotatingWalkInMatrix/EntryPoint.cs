namespace RotatingWalkInMatrix
{
    using System;
    using System.Collections.Generic;
    using RotatingWalkInMatrix.Models;

    public class EntryPoint
    {
        public static void Main()
        {
            var directionList = new List<Direction>
            {
                new Direction(1, 1),
                new Direction(1, 0),
                new Direction(0, -1),
                new Direction(1, -1),
                new Direction(-1, -1),
                new Direction(-1, 0),
                new Direction(-1, 1),
                new Direction(0, 1)
            };

            var patternFiller = new MatrixPatternFiller(6, 6, directionList);
            patternFiller.FillPatern(new MatrixCell(0, 0));
            Console.WriteLine(patternFiller);
        }
    }
}