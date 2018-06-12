using LinnworksMacroHelpers.Helpers;
using System;

namespace LinnworksMacroHelpers.Classes
{
    /// <summary>
    /// FTP settings for file upload or download, note Active FTP is not supported.
    /// </summary>
    public sealed class FtpSettings : BaseSettings
    {
        public override int Port { get; set; } = 21;

        /// <summary>
        /// FTP Secure socket layer is disabled by default
        /// </summary>
        public bool SSL { get; set; } = false;

        public bool PassiveMode => true;

        public override void Validate()
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
