namespace RotatingWalkInMatrix.Models
{
    public class Direction
    {
        public Direction(int onRow, int onCol)
        {
            this.OnRow = onRow;
            this.OnCol = onCol;
        }

        public int OnRow { get; private set; }

        public int OnCol { get; private set; }
    }
}