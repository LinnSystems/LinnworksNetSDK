using LinnworksMacroHelpers.Helpers;
using LinnworksMacroHelpers.Interfaces;
using System.Runtime.CompilerServices;

namespace LinnworksMacroHelpers
{
    public class LinnworksMacroBase
    {
        public readonly RuntimeHelper RunTime = new RuntimeHelper();
        public LinnworksAPI.ApiObjectManager Api { get; set; }
        public IProxyFactory ProxyFactory { get; set; }
    }
}
