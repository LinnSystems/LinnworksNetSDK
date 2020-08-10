using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RuleActionProperty
	{
		public Int32 ActionPropertyId { get; set; }

		public Int32 ActionId { get; set; }

		public String DisplayName { get; set; }

		public String Value { get; set; }
	} 
}