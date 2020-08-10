using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScriptParameter
	{
		public Int32 ParameterId { get; set; }

		public String Type { get; set; }

		public String Name { get; set; }

		public String Description { get; set; }

		public String DefaultValue { get; set; }

		public String DropDownQuery { get; set; }

		public String DatabaseType { get; set; }

		public Int32 DatabaseTypeLength { get; set; }

		public List<String> AvailableValues { get; set; }

		public Object Value { get; set; }

		public Int32 SortOrder { get; set; }
	} 
}