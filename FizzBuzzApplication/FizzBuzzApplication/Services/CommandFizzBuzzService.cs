using System;
using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public class CommandFizzBuzzService : CommandService, ICommandFizzBuzzService
    {
        public override bool CanServiceFizzBuzz(long number)
        {
            return ((number % Fizz != 0 && number % Buzz != 0) || (number % Fizz == 0 && number % Buzz == 0));
        }

        public override string ServiceFizzBuzz(long number)
        {
            return String.Empty;
        }
    }
}