using System;
using System.Runtime.Serialization;

namespace No8.Solution.Exceptions
{
    [Serializable]
    internal class PrinterModelException : Exception
    {
        public PrinterModelException()
        {
        }

        public PrinterModelException(string message) : base(message)
        {
        }

        public PrinterModelException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PrinterModelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}