namespace WalkInMatrixTest
{
    using MatrixWalk;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RotatingWalkInMatrixTest
    {
        [TestMethod]
        public void TestCreateMatrix_InputSize6_ShouldCreateMatrixCorrectly()
        {
            int[,] actualMatrix = WalkInMatrix.Create2DMatrix(6);

            int[,] expectedMatrix =
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };

            for (int row = 0; row < actualMatrix.GetLength(0); row++)
            {
                for (int column = 0; column < actualMatrix.GetLength(1); column++)
                {
                    Assert.AreEqual(expectedMatrix[row, column], actualMatrix[row, column], "Matrix with size 6 was not created as expected.");
                }
            }
        }
    }
}