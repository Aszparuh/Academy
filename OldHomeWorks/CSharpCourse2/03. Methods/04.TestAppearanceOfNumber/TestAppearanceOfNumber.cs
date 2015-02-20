using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace _04.TestAppearanceOfNumber
{
    [TestClass]
    public class TestAppearanceOfNumber
    {
        [TestMethod]
        public void MissingNumber()
        {
            int[] testArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int searchNum = 17;
            int result = AppearanceOfNumber.TimesAppeared(testArray, searchNum);
            Assert.AreEqual(0, result);
        }
         [TestMethod]
        public void MaxValueTest()
        {
            int maxValue = int.MaxValue;
            int[] testArray = { maxValue, 2, 3, 4, 5, 6, 7, 8, 9, 10, maxValue };
            int seachNum = maxValue;
            int result = AppearanceOfNumber.TimesAppeared(testArray, seachNum);
            Assert.AreEqual(2, result);
        }
    }
}