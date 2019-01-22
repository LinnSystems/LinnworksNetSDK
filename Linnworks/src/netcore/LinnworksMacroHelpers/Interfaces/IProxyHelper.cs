using LinnworksMacroHelpers.Classes;
using LinnworksMacroHelpers.Classes.Email;
using LinnworksMacroHelpers.Classes.Utility;
using System;
using System.IO;
using System.Text;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface ProxyUpload<TSettings, TResult> : IDisposable
        where TSettings : BaseSettings
        where TResult : BaseUploadResult
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
        ProxyUpload<SFtpSettings, SftpUploadResult> GetSFtpUploadProxy(SFtpSettings settings);
        ProxyUpload<FtpsSettings, FtpsUploadResult> GetFtpsUploadProxy(FtpsSettings settings);
        ProxyUpload<DropboxSettings, DropboxUploadResult> GetDropboxUploadProxy(DropboxSettings settings);

        Stream DownloadFtpFile(FtpSettings settings);
        Stream DownloadSFtpFile(SFtpSettings settings);
        Stream DownloadFtpsFile(FtpsSettings settings);
        Stream DownloadDropboxFile(DropboxSettings settings);
        ProxiedWebResponse WebRequest(ProxiedWebRequest request);
        ProxiedEmailResponse SendEmail(ProxiedEmailRequest request);

        ProxiedListDirectoryResponse ListDirectoryFTP(FtpSettings settings);
        ProxiedListDirectoryResponse ListDirectorySFTP(SFtpSettings settings);
        ProxiedListDirectoryResponse ListDirectoryFTPS(FtpsSettings settings);
        ProxiedListDirectoryResponse ListDirectoryDropbox(DropboxSettings settings);
        ProxiedDeleteFileResponse DeleteFileFTP(FtpSettings settings);
        ProxiedDeleteFileResponse DeleteFileSFTP(SFtpSettings settings);
        ProxiedDeleteFileResponse DeleteFileFTPS(FtpsSettings settings);
        ProxiedDeleteFileResponse DeleteFileDropbox(DropboxSettings settings);
        ProxiedRenameFileResponse RenameFileFTP(FtpSettings settings, string newName);
        ProxiedRenameFileResponse RenameFileSFTP(SFtpSettings settings, string newName);
        ProxiedRenameFileResponse RenameFileFTPS(FtpsSettings settings, string newName);
        ProxiedRenameFileResponse RenameFileDropbox(DropboxSettings settings, string newName);
    }
}