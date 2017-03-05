using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Services;

namespace FizzBuzzApplication.Receiver
{
    public class CommandFizzBuzzReceiver : ICommandFizzBuzzReceiver
    {
        //set all services available and sent it to invoker
        public CommandService ReceiveFizzBuzzService(ICommandFizzBuzzService cmdFizzBuzzService)
        {
            CommandFizzBuzzService fizzBuzz = (CommandFizzBuzzService)cmdFizzBuzzService;

            //use reflections
            IEnumerable<ICommandFizzBuzzService> services =
            Assembly.GetExecutingAssembly().GetExportedTypes().Where(
            t => typeof(ICommandFizzBuzzService).IsAssignableFrom(t) && t.IsClass)
            .Select(Activator.CreateInstance)
            .Cast<ICommandFizzBuzzService>();

            // set each service
            foreach (ICommandFizzBuzzService service in services)
                fizzBuzz.SetService(service);
            return fizzBuzz;
        }
    }
}