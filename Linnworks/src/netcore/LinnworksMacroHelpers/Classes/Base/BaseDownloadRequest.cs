namespace LinnworksMacroHelpers.Classes
{
    public class BaseDownloadRequest<T> where T : BaseSettings
    {
        public BaseDownloadRequest(T settings)
        {
            this.Settings = settings;
        }

        public T Settings { get; set; }
    }
}