using System;
using System.Runtime.Serialization;

namespace Business.Services
{
    [Serializable]
    internal class MedicineException : Exception
    {
        public MedicineException()
        {
        }

        public MedicineException(string message) : base(message)
        {
        }

        public MedicineException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MedicineException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}