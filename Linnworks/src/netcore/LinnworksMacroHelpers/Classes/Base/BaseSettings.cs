namespace LinnworksMacroHelpers.Classes
{
    public abstract class BaseSettings
    {
        public string Server { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        /// <summary>
        /// Destination Filename
        /// </summary>
        public string FullPath { get; set; } = "";

        public string Encoding { get; set; } = "";

        public abstract int Port { get; set; }

        public abstract void Validate();
    }
}