using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BookedReturnsExchangeOrder
	{
        /// <summary>
        /// Order ID (unique order identifier) 
        /// </summary>
		public Guid pkOrderID { get; set; }

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId { get; set; }

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum { get; set; }

        /// <summary>
        /// Order seconary reference (Comes from the channel) 
        /// </summary>
		public String SecondaryReference { get; set; }

        /// <summary>
        /// Customer full name 
        /// </summary>
		public String cFullName { get; set; }

        /// <summary>
        /// Return date time 
        /// </summary>
		public DateTime ReturnDate { get; set; }
	} 
}