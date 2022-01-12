using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class used for reqeust parameters for CancelOrderShippingLabel 
    /// </summary>
    public class CancelOrderShippingLabelRequest
	{
        /// <summary>
        /// Unique Order id 
        /// </summary>
		public Guid pkOrderId { get; set; }
	} 
}