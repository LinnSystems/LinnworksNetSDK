using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateAdditionalInfoRequest
	{
        /// <summary>
        /// Linnworks Order Id 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// The Row Id for the order item 
        /// </summary>
		public Guid OrderItemRowId { get; set; }

        /// <summary>
        /// A list of additional information to update or delete from the order item 
        /// </summary>
		public List<OrderItemOptionUpdate> AdditionalInfo { get; set; }
	} 
}