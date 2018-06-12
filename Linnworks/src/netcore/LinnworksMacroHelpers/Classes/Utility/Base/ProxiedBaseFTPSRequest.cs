namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedBaseFTPSRequest
    {
        /// <summary>
        /// The FTPS settings used to connect to the server
        /// </summary>
        public FtpsSettings Settings { get; set; }

        public ProxiedBaseFTPSRequest(FtpsSettings settings)
        {
            Settings = settings;
        }
    }
}
