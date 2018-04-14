namespace LinnworksMacroHelpers.Classes
{
    public sealed class SFtpDownloadRequest
    {
        public SFtpDownloadRequest() { }
        public SFtpDownloadRequest(SFtpSettings settings)
        {
            this.Settings = settings;
        }
        public SFtpSettings Settings { get; set; }
    }
}
