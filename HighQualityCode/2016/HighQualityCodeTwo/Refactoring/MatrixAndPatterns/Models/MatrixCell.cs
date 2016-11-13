namespace MatrixAndPatterns.Logic.Models
{
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
