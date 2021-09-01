using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FluentAssertions;
using Utilities;
using System.Linq;

namespace MyUnitTestProject
{
    [TestClass]
    public class LinqQueriesTest
    {
        LinqQueries linqQueries;


        [TestInitialize]
        public void TestInitialize()
        {
            linqQueries = new LinqQueries();
        }

        /// <summary>
        /// Testing using FluentAssertions.
        /// </summary>
        [TestMethod]
        public void GetResultFromMultiply2ArraysTest()
        {
            int[] dataNumber1 = new[] { 1, 2, 3, 4, 5 };
            int[] dataNumber2 = new[] { 2, 4, 6, 8, 10 };
            int[] arrayExpected = { 4, 16 };

            var results = linqQueries.GetResultFromMultiply2Arrays(dataNumber1, dataNumber2);

            results.Should().Contain(n => n == arrayExpected[0]);
            results.Should().Contain(n => n == arrayExpected[1]);
            results.Should().HaveCount(2);
        }

        [TestMethod]
        public void GetResultForUniting2ArraysTest()
        {
            string[] arrayExpected = { "{ a = 1, c = 3 }",
                                        "{ a = 2, c = 3 }",
                                        "{ a = 3, c = 2 }",
                                        "{ a = 4, c = 1 }",
                                        "{ a = 5, c = 0 }"};
            var data1 = new[] { 1, 2, 3, 4, 5 };
            var data2 = new[] { 1, 2, 3, 1, 2, 3, 4, 1, 2 };

            var results= linqQueries.GetResultForUniting2Arrays(data1, data2);

            results.Should().BeEquivalentTo(arrayExpected);
            results.Should().HaveCount(5);
        }

        [TestMethod]
        public void GetResultWithReverseTest()
        {
            string[] arrayExpected = { "d", "c", "b", "a" };
            string[] data1 = { "a", "b", "c", "d" };
            string[] data2 = { "c", "d", "a" };

            List<string> results = linqQueries.GetResultWithReverse(data1, data2);

            results.Should().BeEquivalentTo(arrayExpected).And.HaveCount(4);
        }

        [TestMethod]
        public void MixingColorTest()
        {
            Car[] data = new[] {
                new Car{ Brand= "A", Color = "Blue"},
                new Car{ Brand= "B", Color = "Blue"},
                new Car{ Brand= "A", Color = "Red"},
                new Car{ Brand= "C", Color = "Green"},
                new Car{ Brand= "D", Color = "Blue"},
            };

            List<IGrouping<string, Car>> results = linqQueries.MixingColor(data);
            results.Should().HaveCount(3);

            results[0].First().Should().BeEquivalentTo(new Car { Brand = "A", Color = "Blue" });
            results[0].Count().Should().Be(3);
            results[1].Last().Should().BeEquivalentTo(new Car { Brand = "A", Color = "Red" });
            results[2].Last().Should().BeEquivalentTo(new Car { Brand = "C", Color = "Green" });
        }

        [TestMethod]
        public void OrderedNameListTest()
        {
            Person[] people = new Person[] { new Person { Id= 1, Name= "Tatiana" },
                                                    new Person { Id= 1, Name= "Mario" },
                                                    new Person { Id= 1, Name= "Ana" },
                                                    new Person { Id= 1, Name= "Cesar" },
                                                    new Person { Id= 1, Name= "Antonio" },
                                                    new Person { Id= 1, Name= "Bianca" }};

            List<string> results = linqQueries.GetOrderedNameList(people);
            results.Should().StartWith("Ana").And.EndWith("Tatiana").And.HaveCount(6);
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            linqQueries = null;
        }
    }
}
