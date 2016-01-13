using ExerciciosDoLivroCleanCode.Chapter_3;
using ExerciciosDoLivroCleanCode.Chapter_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_5
{
    public class BoldWidget: ParentWidget
    {
        private const string rEGEXP = "'''.+?'''";
        private Patterns pattern = new Patterns();
        public BoldWidget(ParentWidget parent, string text)
        {
            
            Matcher match = Pattern1.matcher(text);
            match.find();
            addChildWidgets(match.group(1));
        }

        private void addChildWidgets(object p)
        {
            throw new NotImplementedException();
        }

        public String render()
        {
            StringBuffer html = new StringBuffer("<b>");
            html.append(childHtml());
            html.append("</b>");
            return html.ToString();
        }

        private object childHtml()
        {
            throw new NotImplementedException();
        }

        public static string REGEXP
        {
            get
            {
                return REGEXP1;
            }
        }

        public static string REGEXP1
        {
            get
            {
                return REGEXP2;
            }
        }

        public static string REGEXP2
        {
            get
            {
                return REGEXP3;
            }
        }

        public static string REGEXP3
        {
            get
            {
                return rEGEXP;
            }
        }

        internal  Patterns Pattern
        {
            get
            {
                return Pattern1;
            }
        }

        internal  Patterns Pattern1
        {
            get
            {
                return Pattern2;
            }
        }

        internal  Patterns Pattern2
        {
            get
            {
                return Pattern3;
            }
        }

        internal  Patterns Pattern3
        {
            get
            {
                return Pattern4;
            }
        }

        internal  Patterns Pattern4
        {
            get
            {
                return Pattern5;
            }
        }

        internal  Patterns Pattern5
        {
            get
            {
                return pattern;
            }
        }

        internal  Patterns Pattern6
        {
            get
            {
                return pattern;
            }
        }

        internal Patterns Pattern7
        {
            get
            {
                return pattern;
            }

            set
            {
                pattern = value;
            }
        }
    }
}
