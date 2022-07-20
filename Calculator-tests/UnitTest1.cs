using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator_tests
{
    [TestClass]
    public class UnitTest1


    {
      

        //check if the application can add 2 positive numbers
        [TestMethod]
        public void CalculatorCanAddTwoPositiveIntegers()
        {
            double result = Calculator.Add(1, 1);
            Assert.AreEqual(2,result);
        }

        //check if the application can add a positive double and a negative integer
        [TestMethod]
        public void CalculatorCanAddPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Add(1.1, -1.1);
            Assert.AreEqual(0, result) ;
        }
        //check if the application can add 2 rational numbers
        [TestMethod]
        public void CalculatorCanAddTwoRationalNumbers()
        {
            double result = Calculator.Add(1.1, 1.1);
            Assert.AreEqual(2.2, result);
        }

        //check if the application can add 2 irrational numbers
        [TestMethod]
        public void CalculatorCanAddTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Add(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI * 2, result);
        }

        //check if the application can add 2 zeros
        [TestMethod]
        public void CalculatorCanAddTwoZeros()
        {
            double result = Calculator.Add(0, 0);
            Assert.AreEqual(0, result);
        }

        //check if the application can add 2 negative integers
        [TestMethod]
        public void CalculatorCanAddTwoNegativeIntegers()
        {
            double result = Calculator.Add(-1, -1);
            Assert.AreEqual(- 2, result);
        }

        //check if the application can add 2 negative rational numbers
        [TestMethod]
        public void CalculatorCanAddTwoNegativeRationalNumbers()
        {
            double result = Calculator.Add(-1.1, -1.1);
            Assert.AreEqual(-2.2, result);
        }

        //check if the application can add 2 negative irrational numbers
        [TestMethod]
        public void CalculatorCanAddTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Add(-Math.PI, -Math.PI);
            Assert.AreEqual(-Math.PI * 2, result);
        }

        //check if the application can add a positive integer in the left and a negative integer
        [TestMethod]
        public void CalculatorCanAddLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Add(1, -1);
            Assert.AreEqual(0, result);
        }

        //check if the application can add negative integer in the left with a positive integer
        [TestMethod]
        public void CalculatorCanAddLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Add(-1, 1);
            Assert.AreEqual(0, result);
        }

        //check if the application can subtract 2 positive numbers
        [TestMethod]
        public void CalculatorCanSubTwoPositiveIntegers()
        {
            double result = Calculator.Sub(2, 1);
            Assert.AreEqual(1, result);
        }

        //check if the application can add a positive double and a negative integer
        [TestMethod]
        public void CalculatorCanSubPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Sub(1.1, -1);
            Assert.AreEqual(2.1, result);
        }

        //check if the application can subtract 2 rational numbers
        [TestMethod]
        public void CalculatorCanSubTwoRationalNumbers()
        {
            double result = Calculator.Sub(2.2, 1.1);
            Assert.AreEqual(1.1, result);
        }

        //check if the application can subtract 2 positive irrational numbers
        [TestMethod]
        public void CalculatorCanSubTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Sub(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI - Math.PI, result);
        }

        //check if the application can subtract 2 zeros
        [TestMethod]
        public void CalculatorCanSubTwoZeros()
        {
            double result = Calculator.Sub(0, 0);
            Assert.AreEqual(0, result);
        }

        //check if the application can sub 2 negative integers
        [TestMethod]
        public void CalculatorCanSubTwoNegativeIntegers()
        {
            double result = Calculator.Sub(-2, -3);
            Assert.AreEqual(1, result);
        }

        //check if the application can subtract 2 negative rational numbers
        [TestMethod]
        public void CalculatorCanSubTwoNegativeRationalNumbers()
        {
            double result = Calculator.Sub(-1.1, -1.1);
            Assert.AreEqual(0, result);
        }

        //check if the application can subtract 2 negative irrational numbers
        [TestMethod]
        public void CalculatorCanSubTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Sub(-Math.PI, -Math.PI);
            Assert.AreEqual((-Math.PI) - (-Math.PI), result);
        }

        //check if the application subtract a left positive with a right positive integer
        [TestMethod]
        public void CalculatorCanSubLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Sub(1, -1);
            Assert.AreEqual(2, result);
        }

        //check if the application can subtract negative in the left and positive integers in the right
        [TestMethod]
        public void CalculatorSubLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Sub(-1, 1);
            Assert.AreEqual(-2, result);
        }

        //check if the application can multiply 2 positive integers
        [TestMethod]
        public void CalculatorCanMultiplyTwoPositiveIntegers()
        {
            double result = Calculator.Mul(2, 2);
            Assert.AreEqual(4, result);
        }

        //check if the application can multiply a positive double by a negative integer
        [TestMethod]
        public void CalculatorCanMultiplyPositiveDoubleAndNegativeInteger()
        {
            double result = Calculator.Mul(1.5, 2);
            Assert.AreEqual(3, result);
        }

        //check if the application can multiply 2 rational numbers
        [TestMethod]
        public void CalculatorCanMultiplyTwoRationalNumbers()
        {
            double result = Calculator.Mul(2.5, 1.5);
            Assert.AreEqual(3.75, result);
        }

        //check if the application can multiply 2 irrational numbers
        [TestMethod]
        public void CalculatorCanMultiplyTwoPositiveIrrationalNumbers()
        {
            double result = Calculator.Mul(Math.PI, Math.PI);
            Assert.AreEqual(Math.PI * Math.PI, result);
        }

        //check if the application can multiply 2 zeros

        [TestMethod]
        public void CalculatorCanMultiplyTwoZeros()
        {
            double result = Calculator.Mul(0, 0);
            Assert.AreEqual(0, result);
        }

        //check if the application can multiply 2 negative integers
        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeIntegers()
        {
            double result = Calculator.Mul(-2, -3);
            Assert.AreEqual(6, result);
        }

        //check if the application can multiply 2 negative rational numbers
        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeRationalNumbers()
        {
            double result = Calculator.Mul(-1.5, -1.5);
            Assert.AreEqual(2.25, result);
        }

        //check if the application can multiply 2 negative irrational numbers
        [TestMethod]
        public void CalculatorCanMultiplyTwoNegativeIrrationalNumbers()
        {
            double result = Calculator.Mul(-Math.PI, -Math.PI);
            Assert.AreEqual((-Math.PI) * (-Math.PI), result);
        }


        //check if the application can multiply a positive number in the left by a negative number in the right
        [TestMethod]
        public void CalculatorCanMultiplyLeftPositiveAndRightNegativeIntegers()
        {
            double result = Calculator.Mul(1, -1);
            Assert.AreEqual(-1, result);
        }


        //check if the application can multiply a negative number in the left by a positive number in the right
        [TestMethod]
        public void CalculatorMultiplyAddLeftNegativeAndRightPositiveIntegers()
        {
            double result = Calculator.Mul(-1, 1);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void CalculatorThowsExceptionWhenDividingByZero()
        {

            Assert.ThrowsException<DivideByZeroException>(() => { Calculator.Div(9, 0); });
        }

    }
}
