using System;
using System.Collections.Generic;
using MatrixAndPatterns.Logic.Models;

namespace MatrixAndPatterns.Logic.Utils
{
    public class RotatingWalkMatrixPopulator : BaseMatrixPopulator
    {
        private int currentDirectionIndex = 0;

        private IList<Direction> directions = new List<Direction>
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

        public override void Populate(int[,] matrix)
        {
            var currentCell = new MatrixCell(0, 0);
            int count = 0;

            while (currentCell != null)
            {
                matrix[currentCell.Row, currentCell.Column] = ++count;
                currentCell = this.GetNextCell(currentCell, matrix);
                if (currentCell == null)
                {
                    currentCell = this.FindFirstEmptyCell(matrix);
                }
            }
        }

        private MatrixCell GetNextCell(MatrixCell currentCell, int[,] matrix)
        {
            for (var i = this.currentDirectionIndex; i < this.directions.Count + this.currentDirectionIndex; i++)
            {
                var newCellRow = currentCell.Row + this.directions[i % this.directions.Count].OnRow;
                var newCellColumn = currentCell.Column + this.directions[i % this.directions.Count].OnCol;
                var nextCell = new MatrixCell(newCellRow, newCellColumn);

                if (this.CheckNextPostion(nextCell, matrix))
                {
                    this.currentDirectionIndex = i % this.directions.Count;
                    return nextCell;
                }
            }

            return null;
        }

        private bool CheckNextPostion(MatrixCell cell, int[,] matrix)
        {
            if (this.IsInRange(cell, matrix) && this.IsEmptyCell(cell, matrix))
            {
                return true;
            }

            return false;
        }

        private bool IsInRange(MatrixCell cell, int[,] matrix)
        {
            if (cell.Row < 0 || cell.Row >= matrix.GetLength(0))
            {
                return false;
            }
            else if (cell.Column < 0 || cell.Column >= matrix.GetLength(1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsEmptyCell(MatrixCell cell, int[,] matrix)
        {
            if (matrix[cell.Row, cell.Column] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private MatrixCell FindFirstEmptyCell(int[,] matrix)
        {
            var newCell = new MatrixCell(0, 0);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
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
