using System;
using System.Runtime.Serialization;

namespace Minor.ServiceBus.Agent.Implementation
{
    [Serializable]
    public class MultipleRecordsFoundException : Exception
    {
        public MultipleRecordsFoundException()
        {
        }

        public MultipleRecordsFoundException(string message) : base(message)
        {
        }

        public MultipleRecordsFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MultipleRecordsFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}