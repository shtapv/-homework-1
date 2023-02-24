using System;

namespace RomanNumbersCalculator.Models
{
    internal class RomanNumberException : Exception
    {
        private const string baseErrorMessage = "#ERROR";
        public RomanNumberException(string message = baseErrorMessage) : base(message) { }
    }
}
