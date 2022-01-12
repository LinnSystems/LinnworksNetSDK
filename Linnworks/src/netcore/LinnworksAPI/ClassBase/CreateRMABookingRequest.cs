using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateRMABookingRequest
	{
        /// <summary>
        /// Determines whether the RMA request was initiated on the channel, or within Linnworks 
        /// </summary>
		public Boolean ChannelInitiated { get; set; }

        /// <summary>
        /// The unique identifier for the order a return booking is being created for 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// A collection of items to be returned as part of this booking 
        /// </summary>
		public List<ReturnItem> ReturnItems { get; set; }

        /// <summary>
        /// A collection of items to be exchanged as part of this booking 
        /// </summary>
		public List<ExchangeItem> ExchangeItems { get; set; }

        /// <summary>
        /// A collection of items to be resent as part of this booking 
        /// </summary>
		public List<ResendItem> ResendItems { get; set; }

        /// <summary>
        /// (Optional) If provided, sets the External Reference of the RMA header to the provided value. Otherwise, this value is automatically generated 
        /// </summary>
		public String Reference { get; set; }
	} 
}