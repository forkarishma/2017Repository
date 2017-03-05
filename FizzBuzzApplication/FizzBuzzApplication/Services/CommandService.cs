using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.Services
{
    public abstract class CommandService : ICommandService
    {
        public abstract bool CanServiceFizzBuzz(long number);
        public abstract string ServiceFizzBuzz(long number);

        protected CommandService Service;
        //getters
        protected int Fizz => 3;
        protected int Buzz => 5;
        
        //Provide Service and if not found check for another service
        protected internal string ProvideServiceFizzBuzz(long number)
        {
            return CanServiceFizzBuzz(number) ? ServiceFizzBuzz(number) : Service.ProvideServiceFizzBuzz(number);
        }

        //set chain of services available
        protected internal CommandService SetService(ICommandService newService)
        {
            if (Service == null)
                Service = (CommandService)newService;
            else
                Service.SetService(newService);
            return this;
        }
    }
}