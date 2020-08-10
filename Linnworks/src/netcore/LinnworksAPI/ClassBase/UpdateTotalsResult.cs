using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateTotalsResult
	{
		public OrderTotalsInfo TotalsInfo { get; set; }

		public OrderShippingInfo ShippingInfo { get; set; }
	} 
}