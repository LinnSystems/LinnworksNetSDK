using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InstalledMacro
	{
		public String ApplicationName { get; set; }

		public String ApplicationLogo { get; set; }

		public String MacroName { get; set; }

		public String MacroDescription { get; set; }

		public ExecutionType ExecutionType { get; set; }

		public SourceType SourceCodeType { get; set; }

		public ParameterDefinition[] Parameters { get; set; }
	} 
}