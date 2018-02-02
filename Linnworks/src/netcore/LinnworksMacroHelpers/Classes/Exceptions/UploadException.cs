using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Classes.Exceptions
{
    public class UploadException : Exception
    {
        public UploadException(string message) : base(message) { }
    }
}
