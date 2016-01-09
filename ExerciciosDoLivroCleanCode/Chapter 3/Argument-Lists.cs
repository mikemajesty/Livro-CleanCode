using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    class Argument_Lists
    {
        public void DoSomething(string name,string hours)
        {
            String.Format("{0} worked {0: 2F} hours.", name, hours);
        }
    }
}
