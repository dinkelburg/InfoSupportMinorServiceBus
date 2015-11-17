using System;
using System.Runtime.Serialization;

namespace Minor.ServiceBus.Agent.Implementation
{
    [Serializable]
    public class VersionRecordFoundException : Exception
    {
        public VersionRecordFoundException()
        {
        }

        public VersionRecordFoundException(string message) : base(message)
        {
        }

        public VersionRecordFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VersionRecordFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}