namespace Matrix
{
    using System;
    using System.Text;

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

        public static GenMatrix<T> operator -(GenMatrix<T> matrix1, GenMatrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrix sizes mismatch");
            }
            GenMatrix<T> result = new GenMatrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] - matrix2[i, j];
                }
            }

            return result;
        }

        //Operators
        public static GenMatrix<T> operator +(GenMatrix<T> matrix1, GenMatrix<T> matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Cols != matrix2.Cols)
            {
                throw new InvalidOperationException("Matrix sizes mismatch");
            }
            GenMatrix<T> result = new GenMatrix<T>(matrix1.Rows, matrix1.Cols);

            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    result[i, j] = (dynamic)matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }

        public static GenMatrix<T> operator *(GenMatrix<T> matrix1, GenMatrix<T> matrix2)
        {
            if (matrix1.Cols != matrix2.Rows)
            {
                throw new InvalidOperationException("Matrix sizes mismatch");
            }
            GenMatrix<T> resultMatrix = new GenMatrix<T>(matrix1.Rows, matrix2.Cols);
            T result = (dynamic)0;
            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Cols; j++)
                {
                    for (int k = 0; k < matrix1.Cols; k++)
                    {
                        result += (dynamic)matrix1[i, k] * matrix2[k, j];
                    }

                    resultMatrix[i, j] = result;
                    result = (dynamic)0;
                }
            }

            return resultMatrix;
        }

        public static bool operator true(GenMatrix<T> matrix)
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(GenMatrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(string.Format("{0} ", this.myMatrix[i, j]));
                }

                sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}