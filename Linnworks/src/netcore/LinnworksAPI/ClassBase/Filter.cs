using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Filter
	{
		public FilterNameType FilterName;

		public String DisplayName;

		public List<String> FilterNameExact;

		public InventoryFieldType Field;

		public ConditionType Condition;

		public String ConditionDisplayName;

		public String Value;
	} 
}