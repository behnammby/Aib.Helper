using System;

namespace Behnammby.Common.Exceptions
{
    public class HashInvalidException : ApplicationException
    {
        public HashInvalidException() : base()
        {
            
        }

        public HashInvalidException(string message) : base(message)
        {
            
        }

        public HashInvalidException(string message, Exception innerException) : base(message, innerException)
        {
            
        }
    }
}