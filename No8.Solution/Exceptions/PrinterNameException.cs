using System;
using System.Runtime.Serialization;

namespace No8.Solution.Exceptions
{
    [Serializable]
    internal class PrinterNameException : Exception
    {
        public PrinterNameException()
        {
        }

        public PrinterNameException(string message) : base(message)
        {
        }

        public PrinterNameException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PrinterNameException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}