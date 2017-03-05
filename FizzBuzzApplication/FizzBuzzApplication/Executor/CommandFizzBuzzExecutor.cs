using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Receiver;
using FizzBuzzApplication.Services;

namespace FizzBuzzApplication.Executor
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        public ICommandService CmdFizzBuzzService { get; }
        private ICommandFizzBuzzReceiver CmdFizzBuzzReceiver { get; }

        internal CommandFizzBuzzExecutor()
        {
            CmdFizzBuzzReceiver = new CommandFizzBuzzReceiver();
            CmdFizzBuzzService = new CommandFizzBuzzService();
        }

        public string ExecuteFizzBuzz(long number)
        {
            return CmdFizzBuzzReceiver.ReceiveFizzBuzzService((ICommandFizzBuzzService)CmdFizzBuzzService).ProvideServiceFizzBuzz(number);
        }
    }
}