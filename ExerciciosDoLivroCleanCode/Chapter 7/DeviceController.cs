using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_7
{
    class DeviceController
    {
        public void sendShutDown()
        {
            try
            {
                tryToShutDown();
            }
            catch (DeviceShutDownError e)
            {
                Console.WriteLine(e);
            }
        }
        public List<RecordedGrip> retrieveSection(String sectionName)
        {
            try
            {
                FileInputStream stream = new FileInputStream(sectionName);
            }
            catch (Exception e)
            {
                throw new StorageException("retrieval error", e);
            }
            return new List<RecordedGrip>();
        }
        private void tryToShutDown()
        {
            throw new NotImplementedException();
        }
    }
}
