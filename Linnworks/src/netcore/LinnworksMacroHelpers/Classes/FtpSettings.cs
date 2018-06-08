using System;
using LinnworksMacroHelpers.Helpers;
using LinnworksMacroHelpers.Interfaces;

namespace LinnworksMacroHelpers.Classes
{
    /// <summary>
    /// FTP settings for file upload or download, note Active FTP is not supported.
    /// </summary>
    public sealed class FtpSettings : IUploadSettings
    {
        /// <summary>
        /// FTP server without port
        /// </summary>
        public string Server { get; set; } = "";

        /// <summary>
        /// FTP port 21 by default
        /// </summary>
        public int Port { get; set; } = 21;

        /// <summary>
        /// FTP username
        /// </summary>
        public string UserName { get; set; } = "";

        /// <summary>
        /// FTP Password
        /// </summary>
        public string Password { get; set; } = "";

        /// <summary>
        /// Destination Filename
        /// </summary>
        public string FullPath { get; set; } = "";

        /// <summary>
        /// FTP Secure socket layer is disabled by default
        /// </summary>
        public bool SSL { get; set; } = false;

        public string Encoding { get; set; } = "";

        public bool PassiveMode => true;

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Server))
                throw new ArgumentException("Server cannot be empty", nameof(Server));

            if (string.IsNullOrWhiteSpace(UserName))
                throw new ArgumentException("Server cannot be empty", nameof(Server));

            if (string.IsNullOrWhiteSpace(Password))
                throw new ArgumentException("Server cannot be empty", nameof(Server));

            if (!Port.Between(1, 65535, true))
                throw new AggregateException("Port must be between 1 and 65535");
        }
    }
}
