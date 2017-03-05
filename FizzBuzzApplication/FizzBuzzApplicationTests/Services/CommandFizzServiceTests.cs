using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandFizzServiceTests
    {
        private ICommandService cmdService;

        public long Number { get; set; } = 3;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberFizz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandFizzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotFizz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandFizzService();
            bool result;
            Number = 4;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsFalse(result);
        }

    }
}