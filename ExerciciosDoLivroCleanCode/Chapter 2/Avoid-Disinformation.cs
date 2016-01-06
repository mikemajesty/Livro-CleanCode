using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode
{
    public class Avoid_Disinformation
    {
        /*----------------------bad code-------------------------*/
        private const int O = 1,O1 = 2;
        private int l;
        public void DoSimathing()
        {
            int a = l;
            if (O == l)
                a = O1;
            else
                l = 01;
        }
        /*----------------------beautiful code-------------------------*/
        private const int valueOfDay = 1, valueOfMonth = 2;
        private int valueOfWeek;
        public void ComparingValues()
        {
            int a = l;
            if (valueOfDay == l)
                a = valueOfMonth;
            else
                valueOfWeek = valueOfDay;
        }
    }
}
