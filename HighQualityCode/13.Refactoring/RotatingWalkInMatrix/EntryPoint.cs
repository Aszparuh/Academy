namespace RotatingWalkInMatrix
{
    using RotatingWalkInMatrix.Models;
    using System;
    using System.Collections.Generic;

    class EntryPoint
    {
        static void Main()
        {
            var directionList = new List<Direction>
            {
                new Direction(1, 1),
                new Direction(1, 0),
                new Direction(1, -1),
                new Direction(-1, 1),
                new Direction(-1, 0),
                new Direction(-1, 1),
                new Direction(0, 1)
            };

            var patternFiller = new MatrixPatternFiller(6, 6, directionList);
        }
    }
}