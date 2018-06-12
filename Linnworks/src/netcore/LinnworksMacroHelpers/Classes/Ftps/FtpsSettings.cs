using System;

namespace LinnworksMacroHelpers.Classes
{
    public class FtpsSettings : BaseSettings
    {
        public override int Port { get; set; } = 990;

        /// <summary>
        /// Determines whether to use implict TLS
        /// </summary>
        public bool UseImplicitTLS { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Server))
                throw new ArgumentException("Server cannot be empty", nameof(Server));

            if (string.IsNullOrWhiteSpace(UserName))
                throw new ArgumentException("Server cannot be empty", nameof(Server));

            if (string.IsNullOrWhiteSpace(Password))
                throw new ArgumentException("Server cannot be empty", nameof(Server));
        }
    }
}
