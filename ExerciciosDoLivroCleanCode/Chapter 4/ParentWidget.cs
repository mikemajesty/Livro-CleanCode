using System;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    internal class ParentWidget
    {
        public static implicit operator ParentWidget(BoldWidgets v)
        {
            throw new NotImplementedException();
        }
    }
}