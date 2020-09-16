using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace TemplateProxyExample.Helpers
{
    public static class ServiceHelper
    {
        public static string UserStoreLocation
        {
            get
            { 
                var path = GetSetting();

                if (Directory.Exists(path))
                    Directory.CreateDirectory(path);

                return path;
            }
        }

        private static string GetSetting([CallerMemberName] string name = null)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(name) ?? string.Empty;
        }
    }
}