using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    class Prefer_Exceptions_to_Returning_Error_Codes
    {
        public void delete(Page page)
        {
            try
            {
                deletePageAndAllReferences(page);
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }
        private void deletePageAndAllReferences(Page page)
        {
            deletePage(page);
            registry.deleteReference(page.name);
            configKeys.deleteKey(page.name);
        }

        private void deletePage(Page page)
        {
            throw new NotImplementedException();
        }

        private void logError(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
