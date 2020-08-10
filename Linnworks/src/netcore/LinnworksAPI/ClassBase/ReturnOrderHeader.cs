using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ReturnOrderHeader
	{
        /// <summary>
        /// Order ID 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource { get; set; }

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName { get; set; }

        /// <summary>
        /// Shipping address 
        /// </summary>
		public String cShippingAddress { get; set; }

        /// <summary>
        /// Currency 
        /// </summary>
		public String cCurrency { get; set; }

        /// <summary>
        /// Order received date. When order was downloaded from the channel 
        /// </summary>
		public DateTime dReceivedDate { get; set; }

        /// <summary>
        /// When order was processed 
        /// </summary>
		public DateTime dProcessedOn { get; set; }

        /// <summary>
        /// OrdOrder total charge 
        /// </summary>
		public Double fTotalCharge { get; set; }

        /// <summary>
        /// Link to order refund 
        /// </summary>
		public String RefundLink { get; set; }
	} 
}