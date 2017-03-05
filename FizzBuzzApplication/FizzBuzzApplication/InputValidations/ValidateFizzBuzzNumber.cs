using System;
using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.InputValidations
{
    public class ValidateFizzBuzzNumber : IValidateFizzBuzzNumber
    {
        public bool ValidateFizzBuzznumber(long number)
        {
           return (number > 0 && number <= Int32.MaxValue);
        }
    }
}