using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculatorCanAddTwoPositiveIntegers()
        {
            double result = Calculator.Add(1, 1);
            Assert.AreEqual(2,result);
        }


        [TestMethod]
        public void CalculatorCanAddTwoPositiveDouble()
        {
            double result = Calculator.Add(1.01, 1.01);
            Assert.AreEqual(2.02, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoRationalNumbers()
        {
            double result = Calculator.Add(1.1, 1.1);
            Assert.AreEqual(2.2, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Add(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI * 2, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoZeros()
        {
            double result = Calculator.Add(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoNegativeIntegers()
        {
            double result = Calculator.Add(-1, -1);
            Assert.AreEqual(- 2, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoNegativeRationalNumbers()
        {
            double result = Calculator.Add(-1.1, -1.1);
            Assert.AreEqual(-2.2, result);
        }

        [TestMethod]
        public void CalculatorCanAddTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Add(-Math.PI, -Math.PI);
            Assert.AreEqual(-Math.PI * 2, result);
        }

        [TestMethod]
        public void CalculatorCanAddLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Add(1, -1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorCanAddLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Add(-1, 1);
            Assert.AreEqual(0, result);
        }
    }
}
