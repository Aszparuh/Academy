namespace RotatingWalkInMatrix.Models
{
    using System;
    using System.Collections.Generic;

    class Matrix
    {
        private readonly int[,] matrix;
        
        private List<Direction> directions;
        private int size;

        public Matrix(int size)
        {

        }

        public int Size 
        {
            get
            {
                return this.size;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be positive number");
                }

                this.size = value;
            }
        }
    }
}