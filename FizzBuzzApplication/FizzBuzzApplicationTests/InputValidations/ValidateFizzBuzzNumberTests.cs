using System;
using FizzBuzzApplication.InputValidations;
using FizzBuzzApplication.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.InputValidations
{
    [TestClass()]
    public class ValidateFizzBuzzNumberTests
    {
        public IValidateFizzBuzzNumber ValidateFizzBuzz { get; } = new ValidateFizzBuzzNumber();
        Random r = new Random();
        private bool result;

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectPositiveNumberMax32BitInteger_ReturnsTrue()
        {
            //Arrange
            long number = r.Next(0, Int32.MaxValue);

            //Act
            result = ValidateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number > 0);
            Assert.IsTrue(number <= Int32.MaxValue);
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberMoreThan32BitInteger_ReturnFalse()
        {
            //Arrange
            long number = 12345678910;

            //Act
            result = ValidateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number > Int32.MaxValue);
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ValidateFizzBuzzNumber_ExpectNumberLessThan0_ReturnFalse()
        {
            //Arrange
            long number = -1;

            //Act
            result = ValidateFizzBuzz.ValidateFizzBuzznumber(number);

            //Assert
            Assert.IsTrue(number < 0);
            Assert.IsFalse(result);
        }
    }
}