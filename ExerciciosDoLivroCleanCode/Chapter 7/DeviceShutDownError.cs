using System;
using System.Runtime.Serialization;

namespace ExerciciosDoLivroCleanCode.Chapter_7
{
    [Serializable]
    internal class DeviceShutDownError : Exception
    {
        public DeviceShutDownError()
        {
        }

        public DeviceShutDownError(string message) : base(message)
        {
        }

        public DeviceShutDownError(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DeviceShutDownError(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}