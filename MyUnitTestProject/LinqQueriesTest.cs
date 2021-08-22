using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;

namespace MyUnitTestProject
{
    [TestClass]
    public class LinqQueriesTest
    {
        LinqQueries linqQueries;
        int[] dataNumber1;
        int[] dataNumber2;
        string[] newLines;
        List<string> myStringList;


        [TestInitialize]
        public void TestInitialize()
        {
            linqQueries = new LinqQueries();
            dataNumber1 = new [] { 1, 2, 3, 4, 5 };
            dataNumber2 = new [] { 2, 4, 6, 8, 10 };
            newLines = new string[] { "First line", "Second line", "Third line" };
            myStringList = new List<string>();
        }


        /// <summary>
        /// Testing using FluentAssertions.
        /// </summary>
        [TestMethod]
        public void GetResultFromMultiply2ArraysTest()
        {
            int[] arrayExpected = { 4, 16 };
            var results = linqQueries.GetResultFromMultiply2Arrays(dataNumber1, dataNumber2);

            results.Should().Contain(n => n == arrayExpected[0]);
            results.Should().Contain(n => n == arrayExpected[1]);
            results.Should().HaveCount(2);
        }
    }
}
