using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ShippingCostOverride : LinnObject
	{
		public Int32 Priority { get; set; }

		public String ShippingServiceType { get; set; }

		public String ShippingCost_ExtendedProperty { get; set; }

		public String AdditionalShippingCost_ExtendedProperty { get; set; }
	} 
}