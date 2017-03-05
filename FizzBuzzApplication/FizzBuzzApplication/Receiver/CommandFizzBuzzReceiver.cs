using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;

namespace FizzBuzzApplication.Receiver
{
    public class CommandFizzBuzzReceiver : ICommandFizzBuzzReceiver
    {
        //set all services available and sent it to invoker

        public CommandService ReceiveFizzBuzzService(ICommandFizzBuzzService cmdFizzBuzzService)
        {
            throw new System.NotImplementedException();
        }
    }
}