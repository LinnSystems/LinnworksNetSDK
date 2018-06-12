namespace LinnworksMacroHelpers.Classes.Utility
{
    public class ProxiedRenameFileFTPSRequest : ProxiedBaseFTPSRequest
    {
        public ProxiedRenameFileFTPSRequest(FtpsSettings settings, string newFileName) : base(settings)
        {
            NewFileName = newFileName;
        }

        /// <summary>
        /// The new name for the file, including the type extension
        /// </summary>
        public string NewFileName { get; set; }
    }
}
