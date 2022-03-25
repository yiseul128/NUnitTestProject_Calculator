using NUnit.Framework;
using System;

namespace NUnitTestProject_Calculator
{
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Addition_Test()
        {
            int a = 10, b = 13;
            int expected = 9;
            Assert.AreEqual(expected, calculator.Add(a, b));
        }

        [Test]
        public void Subtraction_Test()
        {
            int a = 20, b = 13;
            int expected = 9;
            Assert.AreEqual(expected, calculator.Subtract(a, b));
        }

        [Test]
        public void Multiplication_Test()
        {
            int a = 10, b = 2;
            int expected = 9;
            Assert.AreEqual(expected, calculator.Muliply(a, b));
        }

        [Test]
        public void Division_Test()
        {
            int a = 20, b = 2;
            int expected = 9;
            Assert.AreEqual(expected, calculator.Divide(a, b));
        }

        [Test]
        public void ZeoDivisionException_Test()
        {
            int a = 10, b = 0;
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(a, b));
        }
    }
}