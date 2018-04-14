using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateOrderShippingInfoRequest
	{
		public Guid? PostalServiceId;

		public Double? TotalWeight;

		public Double? ItemWeight;

		public Double? PostageCost;

		public Double? PostageCostExTax;

		public String TrackingNumber;

		public Boolean? ManualAdjust;
	} 
}