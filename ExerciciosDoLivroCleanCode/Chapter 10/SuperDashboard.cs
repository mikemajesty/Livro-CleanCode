using System;

namespace ExerciciosDoLivroCleanCode.Chapter_9
{
    public interface SuperDashboard
    {
        string getCustomizerLanguagePath();
        void setSystemConfigPath(String systemConfigPath);
        String getSystemConfigDocument();
        void setSystemConfigDocument(String systemConfigDocument);
        bool getGuruState();
        bool getNoviceState();
        bool getOpenSourceState();
        void showObject(object MetaObject);
        void showProgress(String s);
    }
}
