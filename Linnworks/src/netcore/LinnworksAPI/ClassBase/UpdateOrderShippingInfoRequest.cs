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
		public Guid? PostalServiceId { get; set; }

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Decimal? TotalWeight { get; set; }

        /// <summary>
        /// If order is processed 
        /// </summary>
		public Decimal? ItemWeight { get; set; }

        /// <summary>
        /// Order postage cost 
        /// </summary>
		public Double? PostageCost { get; set; }

        /// <summary>
        /// Order tracking number provided by courier 
        /// </summary>
		public String TrackingNumber { get; set; }

        /// <summary>
        /// If there is an adjustment to shipping cost was made 
        /// </summary>
		public Boolean? ManualAdjust { get; set; }
	} 
}