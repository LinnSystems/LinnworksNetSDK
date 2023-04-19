using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInstalledMacrosResponse : LinnObject
	{
		public InstalledMacro[] Macros { get; set; }
	} 
}