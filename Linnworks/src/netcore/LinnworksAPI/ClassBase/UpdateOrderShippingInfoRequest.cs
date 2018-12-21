using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateOrderShippingInfoRequest
	{
        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid? PostalServiceId;

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Double? TotalWeight;

        /// <summary>
        /// If order is processed 
        /// </summary>
		public Double? ItemWeight;

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double? PostageCost;

        /// <summary>
        /// Order postage cost excluding tax 
        /// </summary>
		public Double? PostageCostExTax;

        /// <summary>
        /// Order tracking number provided by courier 
        /// </summary>
		public String TrackingNumber;

        /// <summary>
        /// If there is an adjustment to shipping cost was made 
        /// </summary>
		public Boolean? ManualAdjust;
	} 
}