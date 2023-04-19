using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExecutionOption : LinnObject
	{
		public ExecutionOptionType OptionDetails { get; set; }

		public String DisplayName { get; set; }

		public Object Value { get; set; }
	} 
}