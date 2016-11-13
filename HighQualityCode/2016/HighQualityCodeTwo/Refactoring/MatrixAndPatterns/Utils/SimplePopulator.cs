namespace MatrixAndPatterns.Logic.Utils
{
    public class SimplePopulator : BaseMatrixPopulator
    {
        public override void Populate(int[,] matrix)
        {
            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = ++counter;
                }
            }
        }
    }
}
