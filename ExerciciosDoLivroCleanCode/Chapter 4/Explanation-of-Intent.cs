using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    class Explanation_of_Intent
    {
        private object names;
        private object text;

        public int compareTo(Object o)
        {
            if (o is WikiPagePath)
            {
                WikiPagePath p = (WikiPagePath)o;
                String compressedName = StringUtil.join(names, "");
                String compressedArgumentName = StringUtil.join(p.names, "");
                return compressedName.CompareTo(compressedArgumentName);
            }
            return 1; // we are greater because we are the right type.
        }
        public void testConcurrentAddWidgets()
        {
            WidgetBuilder widgetBuilder =
new WidgetBuilder(new Class[] {   });
            //www.it - ebooks.infoGood Comments
            String text = "'''bold text'''";
            ParentWidget parent = null;
            AtomicBoolean failFlag = new AtomicBoolean();
            failFlag.set(false);
            //This is our best attempt to get a race condition 
            //by creating large number of threads.
            for (int i = 0; i < 25000; i++)
            {
                WidgetBuilderThread widgetBuilderThread =
                new WidgetBuilderThread(widgetBuilder, text, parent, failFlag);
                Thread thread = new Thread(new ThreadStart(assertEquals));
                thread.Start();
            }
            assertEquals(false, failFlag.get());
        }

        private void assertEquals(bool v1, object v2)
        {
            throw new NotImplementedException();
        }

        private void assertEquals()
        {
            throw new NotImplementedException();
        }
    }
}
