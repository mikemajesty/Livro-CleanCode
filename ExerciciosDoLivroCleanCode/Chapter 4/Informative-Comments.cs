using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    abstract class Informative_Comments
    {
        // Returns an instance of the Responder being tested.
        protected Responder ResponderInstance()
        {
            return new Responder { };
        }
        // format matched kk:mm:ss EEE, MMM dd, yyyy
        Pattern timeMatcher = Pattern.compile(
               "\\d*:\\d*:\\d* \\w*, \\w* \\d*, \\d*");
    }
}
