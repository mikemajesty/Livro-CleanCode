using System;
using System.Runtime.Serialization;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    [Serializable]
    internal class InvalidEmployeeType : Exception
    {
        private int type;

        public InvalidEmployeeType()
        {
        }

        public InvalidEmployeeType(string message) : base(message)
        {
        }

        public InvalidEmployeeType(int type)
        {
            this.type = type;
        }

        public InvalidEmployeeType(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidEmployeeType(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}