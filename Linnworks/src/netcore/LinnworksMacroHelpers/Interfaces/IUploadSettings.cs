using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface IUploadSettings
    {
        string FullPath { get; set; }
        string Encoding {get;set;}
    }
}
