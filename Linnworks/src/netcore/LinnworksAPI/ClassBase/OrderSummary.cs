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
		public Guid OrderId { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 NumOrderId { get; set; }

        /// <summary>
        /// Date when order was received on a channel 
        /// </summary>
		public DateTime ReceivedDate { get; set; }

        /// <summary>
        /// Date when order was processed 
        /// </summary>
		public DateTime ProcessDate { get; set; }

        /// <summary>
        /// Channel name / source (e.g. EBAY) 
        /// </summary>
		public String Source { get; set; }

        /// <summary>
        /// Customer name 
        /// </summary>
		public String CustomerName { get; set; }

        /// <summary>
        /// Quantity of products on an Order 
        /// </summary>
		public Int32 NumProducts { get; set; }

        /// <summary>
        /// Order location ID 
        /// </summary>
		public Guid FulfillmentLocationId { get; set; }
	} 
}