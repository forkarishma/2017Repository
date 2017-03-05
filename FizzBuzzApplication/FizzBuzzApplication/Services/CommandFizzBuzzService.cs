using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public class CommandFizzBuzzService : CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            if(number % Fizz == 0)
            return false;
            if (number % Buzz == 0)
                return false;
            return true;
        }

        public override string ServiceFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}