using LinnworksMacroHelpers.Helpers;
using LinnworksMacroHelpers.Interfaces;
using System;

namespace LinnworksMacroHelpers.Classes
{
    public sealed class SFtpSettings : IUploadSettings
    {
        /// <summary>
        /// SFTP Server 
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// SFTP Username
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// SFTP Password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// SFTP Port 22 by default
        /// </summary>
        public Int32 Port { get; set; }
        /// <summary>
        /// Transfer compression disabled by default
        /// </summary>
        public Boolean Compression { get; set; }

        /// <summary>
        /// Optional field.
        /// </summary>
        public string FingerPrint { get; set; }

        public string FullPath { get; set; }
        public string Encoding { get; set; }

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
