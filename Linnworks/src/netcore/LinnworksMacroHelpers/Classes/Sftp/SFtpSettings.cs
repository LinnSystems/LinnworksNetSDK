using LinnworksMacroHelpers.Helpers;
using System;

namespace LinnworksMacroHelpers.Classes
{
    public sealed class SFtpSettings : BaseSettings
    {
        public override int Port { get; set; } = 22;

        /// <summary>
        /// Transfer compression disabled by default
        /// </summary>
        public Boolean Compression { get; set; }

        /// <summary>
        /// Optional field.
        /// </summary>
        public string FingerPrint { get; set; }

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
