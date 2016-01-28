using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LinnAppFramework.Classes
{
    /// <summary>
    /// Class for storing your application settings
    /// </summary>
    public static class AppSettings
    {
        /// <summary>
        /// The ApplicationId of your application. Use Guid.Parse
        /// </summary>
        public static Guid ApplicationId = Guid.Empty;

        /// <summary>
        /// The ApplicationSecret of your application. Use Guid.Parse
        /// </summary>
        public static Guid ApplicationSecret = Guid.Empty;
    }
}