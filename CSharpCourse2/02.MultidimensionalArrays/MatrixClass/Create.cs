namespace MatrixClass
{
    using System;
    using System.Text;

    /*Write a class Matrix, to hold a matrix of integers. Overload the operators for adding, subtracting and 
     * multiplying of matrices, indexer for accessing the matrix content and ToString().*/

    class Matrix
    {
        int[,] matrixElements; // field 
        
        public Matrix(int[,] anyMatrix) //Constructor
        {
            this.matrixElements = (int[,])anyMatrix.Clone();
        }

        public int[,] GetMatrix //Property
        {
            get { return matrixElements; }
        }

        public int this[int i, int j] //Property
        {
            get {return matrixElements[i, j]; }
            set { matrixElements[i, j] = value; }
        }

        public int Rows //Property
        {
            get { return matrixElements.GetLength(0); }
        }

        public int Cols //Property
        {
            get { return matrixElements.GetLength(1); }
        }

        public Matrix operator +(Matrix x, Matrix y) //Overload operator +
        {
            if (x.Cols != y.Cols || x.Rows != y.Rows)
            {
                throw new InvalidOperationException("The matrices have different sizes");
            }

            Matrix result = new Matrix(x.GetMatrix);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < x.Cols; j++)
                {
                    result[i, j] += y[i, j];
                }
            }

            return result;
        }

        public Matrix operator -(Matrix x, Matrix y) //Overload operator -
        {
            if (x.Cols != y.Cols || x.Rows != y.Rows)
            {
                throw new InvalidOperationException("The matrices have different sizes");
            }

            Matrix result = new Matrix(x.GetMatrix);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < x.Cols; j++)
                {
                    result[i, j] -= y[i, j];
                }
            }

            return result;
        }

        public Matrix operator *(Matrix x, Matrix y) //Overload operator *
        {
            if (x.Cols != x.Rows)
            {
                throw new InvalidOperationException("The matrice have different sizes");
            }

            int[,] res = new int[x.Rows, y.Cols];
            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < y.Cols; j++)
                {
                    for (int k = 0; k < x.Cols; k++)
                    {
                        res[i, j] = res[i, j] + x[i, k] * y[k, j];
                    }
                }
            }

            Matrix result = new Matrix(res);
            return result;
        }

        public override string ToString() // Override ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    sb.Append(this[i, j].ToString().PadLeft(4));
                }

                sb.Append(System.Environment.NewLine);
            }

            return sb.ToString();
        }
    }

    class Create
    {

        static void Main()
        {
            Matrix matrix1 = new Matrix(new int[,] 
        {   { 12, 11, 10 }, 
            {  9,  8,  7 }, 
            {  6,  5,  4 }, 
            {  3,  2,  1 } });
            Matrix matrix2 = new Matrix(new int[,] 
        {   {  1,  2,  3 }, 
            {  4,  5,  6 }, 
            {  7,  8,  9 }, 
            { 10, 11, 12 } });

            Console.WriteLine("Matrix 1:");
            Console.WriteLine(matrix1);
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(matrix2);
            Console.WriteLine();

            Console.WriteLine("Matrix1 + Matrix2:");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine();

            Console.WriteLine("Matrix1 - Matrix2:");
            Console.WriteLine(matrix1 - matrix2);
            Console.WriteLine();

            matrix1 = new Matrix(new int[,]
            {   
                { 1, 2 }, 
                { 3, 4 }, 
                { 5, 6 } 
            });

            matrix2 = new Matrix(new int[,] 
            {   
                { 1, 2, 3, 4 }, 
                { 5, 6, 7, 8 } 
            });
            Console.WriteLine("Matrix 1:");
            Console.WriteLine(matrix1);
            Console.WriteLine("Matrix 2:");
            Console.WriteLine(matrix2);
            Console.WriteLine();

            Console.WriteLine("Matrix1 * Matrix2:");
            Console.WriteLine(matrix1 * matrix2);
        }
    }
}