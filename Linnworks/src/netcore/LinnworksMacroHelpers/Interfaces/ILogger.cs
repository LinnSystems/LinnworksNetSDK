namespace LinnworksMacroHelpers.Interfaces
{
    public interface ILogger
    {
        void WriteDebug(string message);
        void WriteError(string message);
        void WriteInfo(string message);
        void WriteWarning(string message);
    }
}