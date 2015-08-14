namespace RotatingWalkInMatrix.Models
{
    using System;

    public class MatrixCell
    {
        private int row;
        private int col;

        public MatrixCell(int row, int col)
        {
            this.Row = row;
            this.Column = col;
        }

        public int Row 
        { 
            get
            {
                return this.row;
            }
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Row cannot be negative");
                }

                this.row = value;
            }
        }

        public int Column
        {
            get
            {
                return this.col;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Column cannot be negative");
                }

                this.col = value;
            }
        }
    }
}