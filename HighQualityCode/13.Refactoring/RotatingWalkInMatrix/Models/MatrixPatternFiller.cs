namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Collections.Generic;

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

        private void FillPatern(MatrixCell startingCell)
        {
            var currentRow = startingCell.Row;
            var currentCol = startingCell.Column;
            int count = 0;

            while (true)
            {
                this.matrix[currentRow, currentCol] = ++count;
                currentRow += this.Directions[currentDirectionIndex].OnRow;
                currentCol += this.Directions[currentDirectionIndex].OnCol;

                if (CheckNextPostion(currentRow, currentCol))
                {
                    continue;    
                }
                else
                {
                    this.currentDirectionIndex = this.currentDirectionIndex + 1 % this.Directions.Count; 
                }
            }
        }

        private bool CheckNextPostion(int row, int col)
        {
            if (IsInRange(row, col))
            {
                return true;
            }

            if (IsEmptyCell(row, col))
            {
                return true;
            }

            return false;
        }

        private bool IsInRange(int row, int col)
        {
            if (0 > row || row > this.Rows)
            {
                return false;
            }

            if (0 > col || col > this.Columns)
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
    }
}