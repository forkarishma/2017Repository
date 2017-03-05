using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandFizzBuzzServiceTests
    {
        private ICommandService cmdService;
        private long number = 1234;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotFizzBuzz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandFizzBuzzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(number);

            //Assert
            Assert.IsTrue(result);
        }
    }
}