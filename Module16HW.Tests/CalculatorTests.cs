using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Module16HW.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Additional(10, 15) == 25);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Subtraction(40, 20) == 20);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Multiplication(5, 6) == 30);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Division(30, 10) == 3);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
