using System.Collections.Generic;
using MatrixAndPatterns.Logic.Models;
using MatrixAndPatterns.Logic.Utils;
using NUnit.Framework;

namespace MatrixAndPatterns.Tests
{
    [TestFixture]
    public class RotatingWalkPopulatorTests
    {
        [Test]
        public void RotatingWalkPopulatorFillsTheMatrix_Correctly()
        {
            var matrix = new int[5, 5];
            var expectedMatrix = new int[5, 5]
            {
                { 1, 13, 14, 15, 16 },
                { 12, 2, 21, 22, 17 },
                { 11, 23, 3, 20, 18 },
                { 10, 25, 24, 4, 19 },
                { 9, 8, 7, 6, 5 }
            };

            BaseMatrixPopulator populator = new RotatingWalkMatrixPopulator();

            // Template method pattern. Just inherit BaseMatrixPopulator and implement your own population method for matrix.
            populator.Populate(matrix);

            CollectionAssert.AreEqual(matrix, expectedMatrix);
        }
    }
}
