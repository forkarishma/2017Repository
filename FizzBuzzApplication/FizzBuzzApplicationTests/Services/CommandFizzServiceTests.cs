using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandFizzServiceTests
    {
        private ICommandService cmdService;

        public long Number { get; } = 3;

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
    }
}