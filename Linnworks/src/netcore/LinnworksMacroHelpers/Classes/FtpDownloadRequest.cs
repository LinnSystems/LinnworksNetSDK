namespace LinnworksMacroHelpers.Classes
{
    public sealed class FtpDownloadRequest
    {
        public FtpDownloadRequest() { }
        public FtpDownloadRequest(FtpSettings settings)
        {
            this.Settings = settings;
        }
        public FtpSettings Settings { get; set; }
    }
}
