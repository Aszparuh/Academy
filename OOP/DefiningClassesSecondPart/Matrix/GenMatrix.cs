namespace Matrix
{
    using System;

    public class GenMatrix<T> where T : struct
    {
        //fields
        private int rows;
        private int cols;
        private T[,] myMatrix;

        //Properties
        public int Rows
        {
            get { return this.rows; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Rows must be possitive number.");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cols must be possitive number.");
                }

                this.cols = value;
            }
        }

        //Constructors
        public GenMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;

        }

    }
}