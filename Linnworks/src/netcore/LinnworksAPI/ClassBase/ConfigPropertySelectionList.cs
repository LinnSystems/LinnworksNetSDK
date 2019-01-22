using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigPropertySelectionList<SelectStringValueOption,Guid>
	{
		public Boolean Loaded;

		public Int32 pkPropertyId;

		public Boolean IsChanged;

		public Guid PropertyValue;

		public String PropertyType;
	} 
}