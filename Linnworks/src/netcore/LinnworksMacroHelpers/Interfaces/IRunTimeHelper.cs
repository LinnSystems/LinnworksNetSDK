using System;
using System.Collections.Generic;
using System.Text;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface IRuntimeHelper
    {
        TimeSpan RemainingTime { get; }
        int RamLimit { get; }
    }
}
