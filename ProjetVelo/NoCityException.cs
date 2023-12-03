using System;
using System.Runtime.Serialization;

namespace ProjetVelo
{
    [Serializable]
    internal class NoCityException : Exception
    {
        public NoCityException()
        {
        }

        public NoCityException(string message) : base(message)
        {
        }

        public NoCityException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoCityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}