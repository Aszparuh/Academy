using NUnit.Framework;

namespace MatrixAndPatterns.Tests
{
    [TestFixture]
    public class GeneralTests
    {
        [Test]
        public void CollectionAssertWorksWith_Matrices_Equal()
        {
            int[,] matrix = new int[5, 5];
            int[,] secondMatrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var number = i + j + 1;
                    matrix[i, j] = number;
                    secondMatrix[i, j] = number;
                }
            }

            CollectionAssert.AreEqual(matrix, secondMatrix);
        }

        [Test]
        public void CollectionAssertWorksWith_Matrices_NotEqual()
        {
            int[,] matrix = new int[5, 5];
            int[,] secondMatrix = new int[5, 5];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var number = i + j + 1;
                    matrix[i, j] = number;
                    secondMatrix[i, j] = number + 1;
                }
            }

            CollectionAssert.AreNotEqual(matrix, secondMatrix);
        }

        [Test]
        public void CollectionAssertWorksWith_Matrices_DiferentLengths()
        {
            int[,] matrix = new int[5, 5];
            int[,] secondMatrix = new int[6, 5];

            CollectionAssert.AreNotEqual(matrix, secondMatrix);
        }
    }
}
