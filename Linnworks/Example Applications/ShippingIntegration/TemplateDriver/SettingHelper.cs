using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Web;

namespace TemplateDriver
{
    public class AppSettings
    {        

        public static string DataStoragePath
        {
            get
            {
                return Setting<string>("DataStoragePath");
            }
        }
        public static string ConfigStoragePath
        {
            get
            {
                return Setting<string>("ConfigStoragePath");
            }
        }

        public static string WizardStagesConfigPath
        {
            get
            {
                return Setting<string>("WizardStagesConfigPath");
            }
        }

        public static string ApplicationId
        {
            get
            {
                return Setting<string>("ApplicationId");
            }
        }


        public static string ApplicationSecret
        {
            get
            {
                return Setting<string>("ApplicationSecret");
            }
        }

        public static string LinnworksAPIUrl
        {
            get
            {
                return Setting<string>("LinnworksAPIUrl");
            }
        }      

        public static string LogFile
        {
            get
            {
                return Setting<string>("LogFile");
            }
        }
        public static string ExceptionFile
        {
            get
            {
                return Setting<string>("ExceptionFile");
            }
        }


        public static void LogException(string error, string step) {
            try {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(AppSettings.ExceptionFile, true);
                sw.WriteLine(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss") + " : " + step + " : " + error);
                sw.Close();
            }catch(Exception ex)
            {

            }
        }

        private static T Setting<T>(string name)
        {
            string value = ConfigurationManager.AppSettings[name];

            if (value == null)
            {
                throw new Exception(String.Format("Could not find setting '{0}',", name));
            }

            return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
        }
    }
}