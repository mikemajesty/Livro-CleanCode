using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode
{
    class Avoid_Encodings
    {
        private int s;
        private char[] t;
        /*bad code*/
        public void doSomething()
        {
            for (int j = 0; j < 34; j++)
            {
                s += (t[j] * 4) / 5;
            }
        }



        /*good code*/
        const int WORK_DAYS_PER_WEEK = 5;
        char[] taskEstimate;
        private int realdays;

        public void DoSomethings()
        {
            int realDaysPerIdealDay = 4;
           
            int sum = 0;
            int NUMBER_OF_TASKS = 0;
            for (int j = 0; j < NUMBER_OF_TASKS; j++)
            {
                int realTaskDays = taskEstimate[j] * realDaysPerIdealDay;
                int realTaskWeeks = (realdays / WORK_DAYS_PER_WEEK);
                sum += realTaskWeeks;
            }
        }
    }
}
