using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Filter
	{
		public FilterNameType FilterName { get; set; }

		public String DisplayName { get; set; }

		public List<String> FilterNameExact { get; set; }

		public InventoryFieldType Field { get; set; }

		public ConditionType Condition { get; set; }

		public String ConditionDisplayName { get; set; }

		public String Value { get; set; }
	} 
}