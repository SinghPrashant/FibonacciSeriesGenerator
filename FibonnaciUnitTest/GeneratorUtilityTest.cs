using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciSeriesGenerator;
using System.Linq;

namespace FibonnaciUnitTest
{
    [TestClass]
    public class GeneratorUtilityTest
    {
        [TestMethod]
        public void GetFibonacciSeriesValidInput()
        {
            //Arrange
            var input = 10;
            var ExpectedOutput = new int[10] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            //Act
            var ActualResult = GeneratorUtility.GetFibonacciSeries(input);
            //Assert
            var testResult=ExpectedOutput.SequenceEqual(ActualResult) ;
            Assert.AreEqual(testResult, true);

        }
        [TestMethod]
        public void GetFibonacciSeriesSmallestInput()
        {
            //Arrange
            var input = 3;
            var ExpectedOutput = new int[3] { 0, 1, 1 };
            //Act
            var ActualResult = GeneratorUtility.GetFibonacciSeries(input);
            //Assert
            var testResult = ExpectedOutput.SequenceEqual(ActualResult);
            Assert.AreEqual(testResult, true);

        }
    }
}
