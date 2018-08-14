using System;

namespace LinnworksMacroHelpers.Classes.Exceptions
{
    public sealed class UploadException : Exception
    {
        public UploadException(string message) : base(message) { }
    }
}