using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Executor
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandFizzBuzzReceiver CmdFizzBuzzReceiver { get; }

        internal CommandFizzBuzzExecutor(ICommandFizzBuzzReceiver cmdFizzBuzzReceiver)
        {
            this.CmdFizzBuzzReceiver = cmdFizzBuzzReceiver;
        }

        public string ExecuteFizzBuzz(long number)
        {
            return CmdFizzBuzzReceiver.ReceiveFizzBuzzService().ProvideServiceFizzBuzz(number);
        }
    }
}