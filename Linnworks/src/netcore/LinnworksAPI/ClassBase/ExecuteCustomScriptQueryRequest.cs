using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExecuteCustomScriptQueryRequest
	{
		public String Script { get; set; }

		public Boolean? UseIsoDate { get; set; }
	} 
}