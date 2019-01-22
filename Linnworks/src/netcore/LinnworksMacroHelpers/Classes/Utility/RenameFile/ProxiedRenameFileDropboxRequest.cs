namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedRenameFileDropboxRequest : ProxiedBaseDropboxRequest
    {
        public ProxiedRenameFileDropboxRequest(DropboxSettings settings, string newFileName) : base(settings)
        {
            NewFileName = newFileName;
        }

        /// <summary>
        /// The new name for the file, including the type extension
        /// </summary>
        public string NewFileName { get; set; }
    }
}