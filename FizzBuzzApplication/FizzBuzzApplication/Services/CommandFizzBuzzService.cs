using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public class CommandFizzBuzzService : CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            return true;
        }

        public override string ServiceFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}