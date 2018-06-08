namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedBaseFTPRequest
    {
        /// <summary>
        /// The FTP settings used to connect to the server
        /// </summary>
        public FtpSettings Settings { get; set; }

        public ProxiedBaseFTPRequest(FtpSettings settings)
        {
            Settings = settings;
        }
    }
}
