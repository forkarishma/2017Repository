using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Executor
{
    public class CommandFizzBuzzExecutor : ICommandFizzBuzzExecutor
    {
        private ICommandService _cmdFizzBuzzService;
        private readonly ICommandFizzBuzzReceiver _cmdFizzBuzzReceiver;

        internal CommandFizzBuzzExecutor(ICommandFizzBuzzReceiver cmdFizzBuzzReceiver)
        {
            this._cmdFizzBuzzReceiver = cmdFizzBuzzReceiver;
        }

        public string ExecuteFizzBuzz(long number)
        {
            throw new System.NotImplementedException();
        }
    }
}