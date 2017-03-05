using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandBuzzServiceTests
    {
        private ICommandService cmdService;
        public long Number { get; } = 5;

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberBuzz_ReturnTrue()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            bool result;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsTrue(result);
        }

    }
}