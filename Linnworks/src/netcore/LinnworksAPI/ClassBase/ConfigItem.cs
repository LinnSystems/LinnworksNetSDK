using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigItem<String>
	{
		public Boolean Loaded;

		public Int32 pkPropertyId;

		public Boolean IsChanged;

		public String PropertyValue;

		public String PropertyType;
	} 
}