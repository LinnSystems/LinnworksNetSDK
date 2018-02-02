using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderSummary
	{
        /// <summary>
        /// Order ID (pkOrderId) 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 NumOrderId;

        /// <summary>
        /// Date when order was received on a channel 
        /// </summary>
		public DateTime ReceivedDate;

        /// <summary>
        /// Date when order was processed 
        /// </summary>
		public DateTime ProcessDate;

        /// <summary>
        /// Channel name / source (e.g. EBAY) 
        /// </summary>
		public String Source;

        /// <summary>
        /// Customer name 
        /// </summary>
		public String CustomerName;

        /// <summary>
        /// Quantity of products on an Order 
        /// </summary>
		public Int32 NumProducts;

        /// <summary>
        /// Order location ID 
        /// </summary>
		public Guid FulfillmentLocationId;
	} 
}