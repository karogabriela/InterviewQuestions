using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MyUnitTestProject
{
    /// <summary>
    /// Testing process includes three parts:
    ///     - Arrange
    ///     - Act
    ///     - Assert
    /// </summary>
    [TestClass]
    public class MyFirstUnitTest
    {        
        [TestMethod]
        public void MyFirstUnitTestMethod()
        {
            //Arrange
            string myStringToAssert = "This is a test";
            //Act
            string myResultedString = myStringToAssert.Remove(0,myStringToAssert.Length);
            //Assert
            Assert.AreEqual(0, myResultedString.Length);
        }
    }
}
