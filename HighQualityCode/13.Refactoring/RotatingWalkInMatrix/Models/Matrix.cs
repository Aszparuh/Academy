namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Collections.Generic;

    class Matrix
    {
        private readonly int[,] matrix;
        
        private List<Direction> directions;
        private int rows;
        private int columns;

        public Matrix(int rows, int colums, IList<Direction> directions)
        {
            this.Rows = rows;
            this.Columns = columns;
            this.Directions = directions;
            this.matrix = new int[this.Rows, this.Columns];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Rows must be positive number");
                }

                this.rows = value;
            }
        }

        public int Columns 
        {
            get
            {
                return this.columns;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Columns must be positive number");
                }

                this.columns = value;
            }
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

                if (value.Count == 0)
                {
                    throw new ArithmeticException("Directions cannot be empty");
                }

                this.directions = new List<Direction>(value);
            }
        }
    }
}