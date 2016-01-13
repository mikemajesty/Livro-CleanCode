using System;

namespace ExerciciosDoLivroCleanCode.Chapter_5
{
    internal class InputStream
    {
        public static implicit operator InputStream(FileInputStream v)
        {
            throw new NotImplementedException();
        }

        internal void close()
        {
            throw new NotImplementedException();
        }
    }
}