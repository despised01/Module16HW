using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Module16HW.Tests

    // создан класс для тестирования класса "Calcultor"
{
    [TestFixture]
    public class CalculatorTests
    {

        // тестирование функции сложения

        [Test]
        public void AdditionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Additional(10, 15) == 25);
        }

        // тестирование функции вычитания

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Subtraction(40, 20) == 20);
        }

        // тестирование функции умножения

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Multiplication(5, 6) == 30);
        }

        // тестирование функции деления

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.True(calculator.Division(30, 10) == 3);
        }

        // тестирование функции невозможности деления на 0

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
