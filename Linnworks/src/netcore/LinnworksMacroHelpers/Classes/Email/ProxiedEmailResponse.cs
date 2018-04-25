using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Classes.Email
{
    public sealed class ProxiedEmailResponse
    {
        public bool IsError { get; set; }
        public string Error { get; set; }
        public bool IsSuccess { get; set; } = true;
    }
}
