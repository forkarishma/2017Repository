using System;
using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandFizzBuzzServiceTests
    {
        private ICommandService cmdService;
        public long Number { get; set; } = 1234;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotFizzBuzz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberFizz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;
            Number = 3;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberBuzz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;
            Number = 5;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberMultipleFizzBuzz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;
            Number = 15;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ServiceFizzBuzzTest_ReturnEmptyString()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            string result;

            //Act
            result = cmdService.ServiceFizzBuzz(Number);

            //Assert
            Assert.AreEqual(String.Empty, result);
        }
    }
}