using LinnworksMacroHelpers.Classes;
using LinnworksMacroHelpers.Classes.Email;
using LinnworksMacroHelpers.Classes.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
        ProxyUpload<SFtpSettings, FtpUploadResult> GetSFtpUploadProxy(SFtpSettings settings);
        
        Stream DownloadFtpFile(FtpSettings settings);
        Stream DownloadSFtpFile(SFtpSettings settings);
        ProxiedWebResponse WebRequest(ProxiedWebRequest request);
        ProxiedEmailResponse SendEmail(ProxiedEmailRequest request);

        ProxiedListDirectoryResponse ListDirectoryFTP(FtpSettings settings);
        ProxiedListDirectoryResponse ListDirectorySFTP(SFtpSettings settings);
        ProxiedDeleteFileResponse DeleteFileFTP(FtpSettings settings);
        ProxiedDeleteFileResponse DeleteFileSFTP(SFtpSettings settings);
        ProxiedRenameFileResponse RenameFileFTP(FtpSettings settings, string newName);
        ProxiedRenameFileResponse RenameFileSFTP(SFtpSettings settings, string newName);
    }
}
