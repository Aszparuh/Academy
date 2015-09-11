namespace RotatingWalkInMatrix.Models
{
    using System;

    public class MatrixCell
    {
        public MatrixCell(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }

        public int Row { get; set; }

        public int Column { get; set; }
    }
}