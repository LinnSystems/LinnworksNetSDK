using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigProperty<Boolean>
	{
		public Boolean Loaded { get; set; }

		public Int32 pkPropertyId { get; set; }

		public Boolean IsChanged { get; set; }

		public Boolean PropertyValue { get; set; }

		public String PropertyType { get; set; }
	} 
}