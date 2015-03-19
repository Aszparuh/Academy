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

        public T[,] GetMatrix
        {
            get {return this.myMatrix; }
        }

        //Constructors
        public GenMatrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.myMatrix = new T[Rows, Cols];
        }

        public GenMatrix(T[,] readyMatrix)
        {
            this.myMatrix = readyMatrix;
            this.rows = readyMatrix.GetLength(0);
            this.cols = readyMatrix.GetLength(1);
        }

        //Indexer
        public T this[int indexRows, int indexCols]
        {
            get
            {
                if (indexRows > this.rows - 1 || indexRows < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                if (indexCols > this.cols - 1 || indexCols < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                return this.myMatrix[indexRows, indexCols];
            }
            set
            {
                if (indexRows > this.rows - 1 || indexRows < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                if (indexCols > this.cols - 1 || indexCols < 0)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                this.myMatrix[indexRows, indexCols] = value;
            }
        }
    }
}