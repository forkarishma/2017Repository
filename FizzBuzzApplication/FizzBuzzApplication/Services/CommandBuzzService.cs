using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public class CommandBuzzService :CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            if (number%Buzz != 0)
                return false;
            return true;
        }

        public override string ServiceFizzBuzz(long number)
        {
            return DisplayBuzz;
        }
    }
}