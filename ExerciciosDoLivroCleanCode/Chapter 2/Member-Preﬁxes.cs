using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode
{
    class Member_Preﬁxes
    {
        public class Part
        {
            private String m_dsc; // The textual description
            void setName(String name)
            {
                m_dsc = name;
            }
        }

        public class PartGood
        {
            String description;
            void setDescription(String description)
            {
                this.description = description;
            }
        }
    }
}
