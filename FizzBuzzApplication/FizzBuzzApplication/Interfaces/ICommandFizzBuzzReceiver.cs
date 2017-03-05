using FizzBuzzApplication.Services;

namespace FizzBuzzApplication.Interfaces
{
    public interface ICommandFizzBuzzReceiver
    {
        CommandService ReceiveFizzBuzzService(ICommandFizzBuzzService cmdFizzBuzzService);
    }
}