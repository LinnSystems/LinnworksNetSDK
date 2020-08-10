using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigItemExternal
	{
		public List<ConfigItemListItem> ListValues;

		public ConfigValueType ValueType;

		public String ConfigItemId;

		public String Name;

		public String Description;

		public String GroupName;

		public Int32 SortOrder;

		public String SelectedValue;

		public String RegExValidation;

		public String RegExError;

		public Boolean MustBeSpecified;

		public Boolean ReadOnly;

		public Boolean HidesHeaderAttribute;
	} 
}