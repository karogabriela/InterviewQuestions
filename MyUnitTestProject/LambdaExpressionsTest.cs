using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MyUnitTestProject
{
    [TestClass]
    public class LambdaExpressionsTest
    {
        LambdaExpressions lambdaExpressions;

        [TestInitialize]
        public void Initialize()
        {
            lambdaExpressions = new LambdaExpressions();
        }

        [TestMethod]
        public void GetTotalCountFromArrayTest()
        {
            string[] myArray = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez" };
            string pattern = "c";
            int result = lambdaExpressions.GetTotalCountFromArray(myArray, pattern);
            result.Should().Be(2);
        }

        [TestMethod]
        public void GetTotalCountWithRegexTest()
        {
            string[] myArray = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez" };
            string pattern = "^[aeiouy]+$";
            int result = lambdaExpressions.GetTotalCountWithRegex(myArray, pattern);
            result.Should().Be(10);
        }

        [TestCleanup]
        public void CleanUp()
        {
            lambdaExpressions = null;
        }
    }
}
