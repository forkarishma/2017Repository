using System;
using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Receiver;
using FizzBuzzApplication.Services;

namespace FizzBuzzApplication.Executor
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        public ICommandService CmdFizzBuzzService { get; }
        private ICommandFizzBuzzReceiver CmdFizzBuzzReceiver { get; }
        public IValidateFizzBuzzNumber ValidateFizzBuzz { get; }

        internal CommandFizzBuzzExecutor(IValidateFizzBuzzNumber validateFizzBuzz)
        {
            CmdFizzBuzzReceiver = new CommandFizzBuzzReceiver();
            CmdFizzBuzzService = new CommandFizzBuzzService();
            ValidateFizzBuzz = validateFizzBuzz;
        }

        public string ExecuteFizzBuzz(long number)
        {
            if (ValidateFizzBuzz.ValidateFizzBuzznumber(number))
                return CmdFizzBuzzReceiver.ReceiveFizzBuzzService((ICommandFizzBuzzService)CmdFizzBuzzService).ProvideServiceFizzBuzz(number);
            return String.Empty;
        }
    }
}