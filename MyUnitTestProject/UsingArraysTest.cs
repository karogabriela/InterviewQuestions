using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTestProject
{
    [TestClass]
    public class UsingArraysTest
    {
        UsingArrays usingArraysTest;

        [TestInitialize]
        public void Initialize()
        {
            usingArraysTest = new UsingArrays();
        }

        [TestMethod]
        public void FindTriplets()
        {            
            int[] data1 = { 1, 2, 3, 1, 1, 1 };
            int[] data2 = { 1, 1, 1, 1, 1, 1 };
            int[] data3 = { 1, 1, 1, 1, 1, 0 };
            int result = 0;

            result = usingArraysTest.FindTriplets(data1);
            Assert.AreEqual(result, 1);
            result = usingArraysTest.FindTriplets(data2);
            Assert.AreEqual(result, 2);
            result = usingArraysTest.FindTriplets(data3);
            Assert.AreEqual(result, 1);
        }
    }
}
