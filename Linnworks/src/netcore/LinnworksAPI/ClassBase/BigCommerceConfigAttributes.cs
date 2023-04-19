using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BigCommerceConfigAttributes : LinnObject
	{
		public String Name { get; set; }

		public BigCommerceAttributeType Type { get; set; }

		public Int32 MaxLength { get; set; }

		public String Label { get; set; }

		public String Value { get; set; }

		public String ExtendedProperty { get; set; }

		public Boolean Default { get; set; }
	} 
}