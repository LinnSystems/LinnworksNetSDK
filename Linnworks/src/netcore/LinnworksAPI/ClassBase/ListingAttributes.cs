using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ListingAttributes : LinnObject
	{
		public String Id { get; set; }

		public String Code { get; set; }

		public String Type { get; set; }

		public Boolean Variation { get; set; }

		public String Label { get; set; }

		public String Value { get; set; }

		public String ExtendedProperty { get; set; }

		public Boolean Default { get; set; }
	} 
}