using NUnit.Framework;
using System;

namespace NUnitTestProject_Calculator
{
    public class CalculatorTests
    {
        private Calculator calculator;
        int a, b, expected;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
            a = 20;
            b = 5;
        }

        [Test]
        public void Addition_Test()
        {
            expected = 9;
            Assert.AreEqual(expected, calculator.Add(a, b));
        }

        [Test]
        public void Subtraction_Test()
        {
            expected = 9;
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        }

        [Test]
        public void Multiplication_Test()
        {
            expected = 9;
            Assert.AreEqual(expected, calculator.Muliply(a, b));
        }

        [Test]
        public void Division_Test()
        {
            expected = 9;
            Assert.AreEqual(expected, calculator.Divide(a, b));
        }

        [Test]
        public void ZeoDivisionException_Test()
        {
            b = 0;
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}