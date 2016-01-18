using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_9
{
    public interface Version
    {

             int getMajorVersionNumber();
             int getMinorVersionNumber();
             int getBuildNumber();
    }
}
