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
		public Guid pkOrderId;

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// ChannelName/Source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Subsource (e.g. EBAY1) 
        /// </summary>
		public String SubSource;

        /// <summary>
        /// Postal service name (e.g. Next day delivery) 
        /// </summary>
		public String PostalServiceName;

        /// <summary>
        /// Shipping address 
        /// </summary>
		public String cShippingAddress;

        /// <summary>
        /// Currency 
        /// </summary>
		public String cCurrency;

        /// <summary>
        /// Order received date. When order was downloaded from the channel 
        /// </summary>
		public DateTime dReceivedDate;

        /// <summary>
        /// When order was processed 
        /// </summary>
		public DateTime dProcessedOn;

        /// <summary>
        /// OrdOrder total charge 
        /// </summary>
		public Double fTotalCharge;

        /// <summary>
        /// Link to order refund 
        /// </summary>
		public String RefundLink;
	} 
}