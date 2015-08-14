namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MatrixPatternFiller
    {
        private int rows;
        private int columns;
        private int[,] matrix;
        private IList<Direction> directions;
        private int currentDirectionIndex;

        public MatrixPatternFiller(int rows, int columns, List<Direction> directions)
        {
            this.Directions = directions;
            this.Rows = rows;
            this.Columns = columns;
            this.matrix = new int[this.Rows, this.Columns];
            this.currentDirectionIndex = 0;
        }

        public IList<Direction> Directions 
        { 
            get
            {
                return this.directions;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Directions cannot be null");
                }

                this.directions = value;
            }
        }

        public int Columns 
        {
            get
            {
                return this.columns;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Columns cannot be negative or zero");
                }

                this.columns = value;
            }
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rows cannot be negative or zero");
                }

                this.rows = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (var i = 0; i < this.Rows; i++)
            {
                for (var j = 0; j < this.Columns; j++)
                {
                    sb.Append(string.Format("{0,3}", this.matrix[i, j]));
                }

                if (i != this.Rows - 1)
                {
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        public void FillPatern(MatrixCell startingCell)
        {
            var currentCell = startingCell;
            int count = 0; 

            while (currentCell != null)
            {
                this.matrix[currentCell.Row, currentCell.Column] = ++count;
                currentCell = this.GetNextCell(currentCell);
                if (currentCell == null)
                {
                    currentCell = this.FindFirstEmptyCell();
                }
            }
        }

        private bool CheckNextPostion(MatrixCell cell)
        {
            if (this.IsInRange(cell.Row, cell.Column) && this.IsEmptyCell(cell.Row, cell.Column))
            {
                return true;
            }

            return false;
        }

        private bool IsInRange(int row, int col)
        {
            if (0 > row || row >= this.Rows)
            {
                return false;
            }

            if (0 > col || col >= this.Columns)
            {
                return false;
            }

            return true;
        }

        private bool IsEmptyCell(int row, int col)
        {
            if (this.matrix[row, col] == 0)
            {
                return true;
            }

            return false;
        }

        private MatrixCell GetNextCell(MatrixCell currentCell)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newCellRow = currentCell.Row + this.directions[i % this.directions.Count].OnRow;
                var newCellColumn = currentCell.Column + this.directions[i % this.directions.Count].OnCol;
                var nextCell = new MatrixCell(newCellRow, newCellColumn);

                if (this.CheckNextPostion(nextCell))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return nextCell;
                }
            }

            return null;
        }

        private MatrixCell FindFirstEmptyCell()
        {
            var newCell = new MatrixCell(0, 0);
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                {
                    if (this.matrix[row, col] == 0)
                    {
                        newCell.Row = row;
                        newCell.Column = col;
                        return newCell;
                    }
                }
            }

            return null;
        }
    }
}