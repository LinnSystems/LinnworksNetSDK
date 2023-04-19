using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AmazonShipping : LinnObject
	{
		public String ShipOption { get; set; }

		public ShippingServiceLevel ServiceLevel { get; set; }

		public Double ShippingCost { get; set; }

		public String ShippingCost_ExtendedProperty { get; set; }

		public ShippingType Type { get; set; }

		public Boolean IsShippingRestricted { get; set; }
	} 
}