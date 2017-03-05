using System;
using FizzBuzzApplication.Interfaces;

namespace FizzBuzzApplication.InputValidations
{
    public class ValidateFizzBuzzNumber : IValidateFizzBuzzNumber
    {
        public bool ValidateFizzBuzznumber(long number)
        {
            if (number > Int32.MaxValue)
                return false;
            return true;
        }
    }
}