using System;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    public class UserValidator
    {
        private Cryptographer cryptographer;

      
        

        public bool checkPassword(String userName, String password)
        {
            User user = UserGateway.findByName(userName);
            if (user != User.NULL)
            {
                String codedPhrase = user.getPhraseEncodedByPassword();
                String phrase = cryptographer.decrypt(codedPhrase, password);
                if ("Valid Password".Equals(phrase))
                {
                    Session.Initialize();
                    return true;
                }
            }
            return false;
        }

        private class UserGateway
        {
            internal static User findByName(string userName)
            {
                throw new NotImplementedException();
            }
        }
    }
}
