using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScriptParameter
	{
		public Int32 ParameterId;

		public String Type;

		public String Name;

		public String Description;

		public String DefaultValue;

		public String DropDownQuery;

		public String DatabaseType;

		public Int32 DatabaseTypeLength;

		public List<String> AvailableValues;

		public Object Value;

		public Int32 SortOrder;
	} 
}