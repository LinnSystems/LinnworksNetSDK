namespace LinnworksMacroHelpers.Classes
{
    public sealed class FtpDownloadRequest : BaseDownloadRequest<FtpSettings>
    {
        public FtpDownloadRequest(FtpSettings settings) : base(settings) { }
    }
}
