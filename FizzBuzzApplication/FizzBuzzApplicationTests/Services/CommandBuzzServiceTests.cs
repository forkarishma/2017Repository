using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzApplicationTests.Services
{
    [TestClass()]
    public class CommandBuzzServiceTests
    {
        private ICommandService cmdService;
        public long Number { get; set; } = 5;

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

        [TestMethod()]
        public void CanServiceFizzBuzzTest_NumberNotBuzz_ReturnFalse()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            bool result;
            Number = 3;

            //Act
            result = cmdService.CanServiceFizzBuzz(Number);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod()]
        public void ServiceFizzBuzzTest_ReturnsBuzz()
        {
            //Arrange
            cmdService = new CommandBuzzService();
            string result;

            //Act
            result = cmdService.ServiceFizzBuzz(Number);

            //Assert
            Assert.AreEqual("Buzz", result);
        }

    }
}