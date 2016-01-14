using System;
using System.Runtime.Serialization;

namespace ExerciciosDoLivroCleanCode.Chapter_7
{
    [Serializable]
    internal class StorageException : Exception
    {
        public StorageException()
        {
        }

        public StorageException(string message) : base(message)
        {
        }

        public StorageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StorageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}