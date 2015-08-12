namespace RotatingWalkInMatrix.Models
{
    class Direction
    {
        public Direction(int onRow, int onCol)
        {
            this.OnRow = onRow;
            this.OnCol = onCol;
        }

        public int OnRow { get; private set; }

        public int OnCol { get; private set; }

        public static Direction operator +(Direction first, Direction second)
        {
            var resultDirection = new Direction(first.OnRow + second.OnRow, first.OnCol + second.OnCol);
            return resultDirection;
        }
    }
}