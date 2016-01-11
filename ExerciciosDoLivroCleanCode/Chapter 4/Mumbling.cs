using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    class Mumbling
    {
        private string propertiesLocation;

        public string PROPERTIES_FILE { get; private set; }

        public void loadProperties()
        {
            try
            {
                String propertiesPath = propertiesLocation + "/" + PROPERTIES_FILE;
                FileInputStream propertiesStream = new FileInputStream(propertiesPath);
                loadedProperties.load(propertiesStream);
            }
            catch (IOException e)
            {
                // No properties files means all defaults are loaded
            }
        }
    }
}
