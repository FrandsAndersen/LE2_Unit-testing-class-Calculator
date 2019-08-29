using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator uut;

        [SetUp]
        public void Setup()
        {
            //Arrange
            uut = new Calculator();
        }

        [TestCase(-3, -4, -7)]
        [TestCase(3, 4, 7)]
        [TestCase(-3, 4, 1)]
        public void AddNumbers_ResultOK(double a, double b, double c)
        {
            //Act
            double number = uut.Add(a,b);

            //Assert
            Assert.AreEqual(c, number);
        }

        [TestCase(-3, 4, -7)]
        [TestCase(8, -2, 6)]
        [TestCase(-8, -8, 16)]
        public void SubtractNumbers_ResultOK(double a, double b, double c)
        {
            //Act
            var number = uut.Subtract(a, b);

            //Assert
            Assert.AreEqual(c, number);
        }

        [TestCase(-2, 2, -4)]
        [TestCase(-5, -5, 25)]
        [TestCase(3, 5, 15)]
        public void MultiplyNumbers_ResultOK(double a, double b, double c)
        {
            //Act
            var number = uut.Multiply(a, b);

            //Assert
            Assert.AreEqual(c, number);
        }
    }
}
