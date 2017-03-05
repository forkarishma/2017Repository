using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzApplication.Executor;
using FizzBuzzApplication.InputValidations;
using FizzBuzzApplication.Interfaces;
using FizzBuzzApplication.Receiver;

namespace FizzBuzzApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ICommandFizzBuzzExecutor cmdFizzBuzzExecutor;
            try
            {
                Console.Write("Please enter a positive number(max 32 bit integer) : ");
                long number = Convert.ToInt64(Console.ReadLine());
                //implement fizzbuzz functionality
                //execute commandfizzbuzz
                cmdFizzBuzzExecutor = new CommandFizzBuzzExecutor(new ValidateFizzBuzzNumber());
                Console.Write(cmdFizzBuzzExecutor.ExecuteFizzBuzz(number));
                Console.Read();
            }
            catch (Exception)
            {
                cmdFizzBuzzExecutor = null;
                Console.Write(String.Empty);
            }
            

        }
    }
}
