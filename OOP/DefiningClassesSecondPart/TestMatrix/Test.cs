namespace TestMatrix
{
    using System;
    using Matrix;

    class Test
    {
        static void Main()
        {
            GenMatrix<int> intMatrix1 = new GenMatrix<int>(new int[,] 
            {   { 35, 11, 15 }, 
            {  9,  18,  7 }, 
            {  5,  5,  4 }, 
            {  3,  2,  8 } });

            GenMatrix<int> intMatrix2 = new GenMatrix<int>(new int[,] 
        {   {  1,  2,  3 }, 
            {  4,  5,  6 }, 
            {  7,  8,  9 }, 
            { 10, 11, 12 } });

            GenMatrix<double> dblMatrix1 = new GenMatrix<double>(new double[,] 
        {   { 2.1, 7.2, 7.3 }, 
            {  4.4,  3.5,  7.6 }, 
            {  6.7,  5.8,  4.9 }, 
            {  3.0,  2.1,  1.2 } });
            GenMatrix<double> dblMatrix2 = new GenMatrix<double>(new double[,] 
        {   {  1.1,  2.2,  3.3, 4.4 }, 
            {  5.5,  6.6,7.7,  8.8 }, 
            { 9.9, 10.0, 11.1, 12.2 } });
            Console.WriteLine("Integer matrix 1:");
            Console.WriteLine(intMatrix1);
            Console.WriteLine("Integer matrix 2:");
            Console.WriteLine(intMatrix2);
            Console.WriteLine();
            Console.WriteLine("Matrix1 + Matrix2:");
            Console.WriteLine(intMatrix1 + intMatrix2);
            Console.WriteLine();

            Console.WriteLine("Double matrix 1:");
            Console.WriteLine(dblMatrix1);
            Console.WriteLine("Double matrix 2:");
            Console.WriteLine(dblMatrix2);
            Console.WriteLine();
            Console.WriteLine("Double Matrix1 + Double Matrix2:");
            Console.WriteLine(dblMatrix1 * dblMatrix2);
            Console.WriteLine();
        }
    }
}