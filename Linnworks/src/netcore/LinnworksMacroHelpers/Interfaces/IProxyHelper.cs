using LinnworksMacroHelpers.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface ProxyUpload<TSettings, TResult> : IDisposable
        where TSettings : IUploadSettings
        where TResult : class
    {
        /// <summary>
        /// Writes supplied bytes to the FTP proxy.
        /// </summary>
        /// <param name="value"></param>
        void Write(byte[] value);

        /// <summary>
        /// Writes the supplied string to the FTP proxy.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="encoding"></param>
        void Write(string value, Encoding encoding = null);

        TResult CompleteUpload();
    }

    public interface IProxyFactory
    {
        ProxyUpload<FtpSettings, FtpUploadResult> GetFtpUploadProxy(FtpSettings settings);
        ProxiedWebResponse WebRequest(ProxiedWebRequest request);
    }
}
