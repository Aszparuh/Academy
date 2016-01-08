namespace Tests
{
    using System;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    
    using Tasks.Extesions;

    [TestClass]
    public class TestLongestSubesequence
    {
        [TestMethod]
        public void TestIfLongestSequenceReturnEmptyListIfSequenceMissing()
        {
            var testList = new List<int>() { 1, 2, 3, 4 };
            var resultList = testList.GetLongestSubsequence();

            CollectionAssert.AreEqual(resultList, new List<int>());
        }

        [TestMethod]
        public void TestIfLongestSequenceReturnsCorrectAnswer()
        {
            var testList = new List<int>() { 1, 2, 2, 3, 4 };
            var resultList = testList.GetLongestSubsequence();

            CollectionAssert.AreEqual(resultList, new List<int>() { 2, 2 });
        }

        [TestMethod]
        public void TestIfLongestSequenceReturnsCorrectAnswerWithTwoSequences()
        {
            var testList = new List<int>() { 1, 2, 2, 3, 4, 4, 4 };
            var resultList = testList.GetLongestSubsequence();

            CollectionAssert.AreEqual(resultList, new List<int>() { 4, 4, 4 });
        }

        [TestMethod]
        public void TestIfLongestSequenceReturnsCorrectAnswerWithTwoEqualSequences()
        {
            ///The method returns only the first sequence of equal numbers
            var testList = new List<int>() { 1, 2, 2, 2, 3, 4, 4, 4 };
            var resultList = testList.GetLongestSubsequence();

            CollectionAssert.AreEqual(resultList, new List<int>() { 2, 2, 2 });
        }
    }
}