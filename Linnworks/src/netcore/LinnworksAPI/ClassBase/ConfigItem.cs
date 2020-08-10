using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigItem<String>
	{
		public Boolean Loaded { get; set; }

		public Int32 pkPropertyId { get; set; }

		public Boolean IsChanged { get; set; }

		public String PropertyValue { get; set; }

		public String PropertyType { get; set; }
	} 
}