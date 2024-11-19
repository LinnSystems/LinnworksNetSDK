using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class MagentoVariationsAttributes : LinnObject
	{
		public String Title { get; set; }

		public List<VariationsAttributesPrices> Prices { get; set; }

		public String Id { get; set; }

		public String Code { get; set; }

		public String ExtendedProperty { get; set; }

		public String Type { get; set; }

		public String Label { get; set; }

		public String Value { get; set; }

		public RequirementTypes Requirement { get; set; }
	} 
}