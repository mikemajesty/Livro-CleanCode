using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    class Explain_Yourself_in_Code
    {
        public bool HOURLY_FLAG { get; private set; }

        public void DoSomething()
        {
            // Check to see if the employee is eligible for full benefits
            if ((employee.flags & HOURLY_FLAG) &&
                (employee.age > 65))
            {

            }
            //or this
            if (employee.isEligibleForFullBenefits()) { }


        }
    }
}
