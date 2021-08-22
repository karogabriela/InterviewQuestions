using System;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyUnitTestProject
{
    [TestClass]
    public class PrimeNumbersTest
    {
        private PrimeNumbers primeNumbers;
        private int[] under100PrimeNumber;
        private int[] compositeNumber;
        private Random myRandom;

        [TestInitialize]
        public void Initialize()
        {
            primeNumbers = new PrimeNumbers();
            under100PrimeNumber = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            compositeNumber = new int[] { 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21, 22, 24, 25, 26, 27, 28, 30, 32, 33, 34, 35, 36, 38, 39, 40, 42, 44, 45, 46, 48, 49, 50, 51, 52, 54, 55, 56, 57, 58, 60, 62, 63, 64, 65, 66, 68, 69, 70, 72, 74, 75, 76, 77, 78, 80, 81, 82, 84, 85, 86, 87, 88, 90, 91, 92, 93, 94, 95, 96, 98, 99, 100 };
            myRandom = new Random();
        }

        [TestMethod]
        public void IsAPrimeNumberTest()
        {
            int position = myRandom.Next(0,under100PrimeNumber.Length);
            Assert.IsTrue(primeNumbers.CheckPrimeNumber(under100PrimeNumber[position]));
        }

        [TestMethod]
        public void IsNotAPrimeNumberTest()
        {
            int position = myRandom.Next(0, compositeNumber.Length);
            Assert.IsFalse(primeNumbers.CheckPrimeNumber(compositeNumber[position]));
        }
    }
}
