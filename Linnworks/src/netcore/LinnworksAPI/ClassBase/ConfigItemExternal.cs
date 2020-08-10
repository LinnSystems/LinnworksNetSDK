using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigItemExternal
	{
		public List<ConfigItemListItem> ListValues { get; set; }

		public ConfigValueType ValueType { get; set; }

		public String ConfigItemId { get; set; }

		public String Name { get; set; }

		public String Description { get; set; }

		public String GroupName { get; set; }

		public Int32 SortOrder { get; set; }

		public String SelectedValue { get; set; }

		public String RegExValidation { get; set; }

		public String RegExError { get; set; }

		public Boolean MustBeSpecified { get; set; }

		public Boolean ReadOnly { get; set; }

		public Boolean HidesHeaderAttribute { get; set; }
	} 
}