using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode
{
    class Use_Pronounceable_Names {
        public static void copyChars(char[] a1, char[] a2)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = a1[i];
            }
        }


    }
    class DtaRcrd102
    {
        private DateTime genymdhms;
        private DateTime modymdhms;
        private const String pszqint = "102";
}
    class Customer
    {
        private DateTime generationTimestamp;
        private DateTime modificationTimestamp;
        private const String recordId = "102";
}
}
