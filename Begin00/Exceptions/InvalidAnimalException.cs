using System;

namespace Begin00.Exceptions
{
    public class InvalidAnimalException : Exception
    {
        public InvalidAnimalException(string message) : base(message) { }
    }
}