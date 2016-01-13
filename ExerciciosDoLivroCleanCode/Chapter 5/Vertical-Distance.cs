using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_5
{
    class Vertical_Distance
    {
        private static void readPreferences()
        {

            InputStream iss = null;
            try
            {
                iss = new FileInputStream();
                setPreferences(new Properties(getPreferences()));
                getPreferences();
            }
            catch (IOException e)
            {
                try
                {
                    if (iss != null)
                        iss.close();
                }
                catch (IOException e1)
                {
                }
            }
        }

        private static object getPreferences()
        {
            throw new NotImplementedException();
        }

        private static void setPreferences(Properties properties)
        {
            throw new NotImplementedException();
        }

        private static object getPreferencesFile()
        {
            throw new NotImplementedException();
        }
    }
}
