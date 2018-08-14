using System;

namespace LinnworksMacroHelpers.Interfaces
{
    public interface IRuntimeHelper
    {
        TimeSpan RemainingTime { get; }
        int RamLimit { get; }
    }
}