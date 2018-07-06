using System;

namespace LinnworksMacroHelpers.Classes
{
    public class MacroConfigurationProxy
    {
        /// <summary>
        /// Identifies the application the macro is running under
        /// </summary>
        public string ApplicationName { get; private set; }
        /// <summary>
        /// When a macro has been run previously, this field will be populated with the last run date
        /// </summary>
        public DateTime LastRun { get; private set; }

        public MacroConfigurationProxy(string appName, DateTime lastRun)
        {
            ApplicationName = appName;
            LastRun = lastRun;
        }
    }
}
