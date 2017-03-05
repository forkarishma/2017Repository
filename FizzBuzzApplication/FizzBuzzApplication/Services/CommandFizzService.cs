using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public class CommandFizzService : CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            return (number % Fizz == 0);
        }

        public override string ServiceFizzBuzz(long number)
        {
            return DisplayFizz;
        }

    }
}