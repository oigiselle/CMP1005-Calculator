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
        public void CalculatorCanAddPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Add(1.1, -2);
            Assert.AreEqual(-1.1, result) ;
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

        [TestMethod]
        public void CalculatorCanSubTwoPositiveIntegers()
        {
            double result = Calculator.Sub(2, 1);
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void CalculatorCanSubPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Sub(1.1, -1);
            Assert.AreEqual(2.1, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoRationalNumbers()
        {
            double result = Calculator.Sub(2.2, 1.1);
            Assert.AreEqual(1.1, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Sub(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI - Math.PI, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoZeros()
        {
            double result = Calculator.Sub(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoNegativeIntegers()
        {
            double result = Calculator.Sub(-2, -3);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoNegativeRationalNumbers()
        {
            double result = Calculator.Sub(-1.1, -1.1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorCanSubTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Sub(-Math.PI, -Math.PI);
            Assert.AreEqual((-Math.PI) - (-Math.PI), result);
        }

        [TestMethod]
        public void CalculatorCanSubLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Sub(1, -1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void CalculatorSubAddLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Sub(-1, 1);
            Assert.AreEqual(-2, result);
        }


        [TestMethod]
        public void CalculatorCanMultiplyTwoPositiveIntegers()
        {
            double result = Calculator.Mul(2, 2);
            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void CalculatorCanMultiplyPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Mul(1.5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoRationalNumbers()
        {
            double result = Calculator.Mul(2.5, 1.5);
            Assert.AreEqual(3.75, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Mul(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI * Math.PI, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoZeros()
        {
            double result = Calculator.Mul(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeIntegers()
        {
            double result = Calculator.Mul(-2, -3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeRationalNumbers()
        {
            double result = Calculator.Mul(-1.5, -1.5);
            Assert.AreEqual(2.25, result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Mul(-Math.PI, -Math.PI);
            Assert.AreEqual((-Math.PI) * (-Math.PI), result);
        }

        [TestMethod]
        public void CalculatorCanMultiplyLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Mul(1, -1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculatorMultiplyAddLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Mul(-1, 1);
            Assert.AreEqual(-1, result);
        }
    }
}
