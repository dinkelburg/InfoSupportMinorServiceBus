using System;
using System.Runtime.Serialization;

namespace Minor.ServiceBus.Agent.Implementation
{
    [Serializable]
    public class BindingNotSupportedException : Exception
    {
        public BindingNotSupportedException()
        {
        }

        public BindingNotSupportedException(string message) : base(message)
        {
        }

        public BindingNotSupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BindingNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}