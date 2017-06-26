using System;

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
        public static Guid ApplicationId = new Guid("0f5813ff-b9a2-4733-978b-8ed5646a43e0");

        /// <summary>
        /// The ApplicationSecret of your application. Use Guid.Parse
        /// </summary>
        public static Guid ApplicationSecret = new Guid("ea3ab978-d7ae-45d3-8eb3-04c2c4bd0ac3");
    }
}