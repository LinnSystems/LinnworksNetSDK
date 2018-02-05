using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Classes
{
    public class FtpDownloadRequest
    {
        public FtpDownloadRequest() { }
        public FtpDownloadRequest(FtpSettings settings)
        {
            this.Settings = settings;
        }
        public FtpSettings Settings { get; set; }
    }
}
