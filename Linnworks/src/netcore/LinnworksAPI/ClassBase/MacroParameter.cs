using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MacroParameter : LinnObject
	{
		public Int32 MacroId { get; set; }

		public String ParameterName { get; set; }

		public String ParameterValue { get; set; }

		public Boolean IsSecure { get; set; }
	} 
}