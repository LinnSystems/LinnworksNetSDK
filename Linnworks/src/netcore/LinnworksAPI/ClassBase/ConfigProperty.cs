using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ConfigProperty<Boolean>
	{
		public Boolean Loaded;

		public Int32 pkPropertyId;

		public Boolean IsChanged;

		public Boolean PropertyValue;

		public String PropertyType;
	} 
}