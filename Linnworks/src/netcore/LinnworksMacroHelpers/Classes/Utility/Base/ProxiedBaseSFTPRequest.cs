namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedBaseSFTPRequest
    {
        /// <summary>
        /// The SFTP settings used to connect to the server
        /// </summary>
        public SFtpSettings Settings { get; set; }

        public ProxiedBaseSFTPRequest(SFtpSettings settings)
        {
            Settings = settings;
        }
    }
}
