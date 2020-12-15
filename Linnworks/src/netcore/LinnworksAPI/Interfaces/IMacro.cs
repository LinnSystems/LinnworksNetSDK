using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IMacroController
	{
		GetInstalledMacrosResponse GetInstalledMacros(GetInstalledMacroRequest request);
		List<MacroRegister> GetMacroConfigurations(GetMacroConfigurationsRequest request);
	} 
}