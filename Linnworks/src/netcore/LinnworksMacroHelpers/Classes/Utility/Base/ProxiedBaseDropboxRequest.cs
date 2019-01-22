namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedBaseDropboxRequest
    {
        /// <summary>
        /// The Dropbox settings used to connect to the server
        /// </summary>
        public DropboxSettings Settings { get; set; }

        public ProxiedBaseDropboxRequest(DropboxSettings settings)
        {
            Settings = settings;
        }
    }
}
