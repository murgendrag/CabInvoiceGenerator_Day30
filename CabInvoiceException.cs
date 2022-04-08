using System.Runtime.Serialization;

namespace CabInvoiceGenerator
{
    [Serializable]
    internal class CabInvoiceException : Exception
    {
        private object iNVALID_RIDE_TYPE;
        private string v;

        public CabInvoiceException()
        {
        }

        public CabInvoiceException(string? message) : base(message)
        {
        }

        public CabInvoiceException(object iNVALID_RIDE_TYPE, string v)
        {
            this.iNVALID_RIDE_TYPE = iNVALID_RIDE_TYPE;
            this.v = v;
        }

        public CabInvoiceException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CabInvoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public static object ExceptionType { get; internal set; }
    }
}