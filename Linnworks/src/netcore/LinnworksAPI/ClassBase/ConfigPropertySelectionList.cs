using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPropertySelectionList<SelectStringValueOption,Guid>
	{
		public Boolean Loaded { get; set; }

		public Int32 pkPropertyId { get; set; }

		public Boolean IsChanged { get; set; }

		public Guid PropertyValue { get; set; }

		public String PropertyType { get; set; }
	} 
}