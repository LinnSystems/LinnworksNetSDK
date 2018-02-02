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
		public Guid pkOrderID;

        /// <summary>
        /// Linnworks order number 
        /// </summary>
		public Int32 nOrderId;

        /// <summary>
        /// Order reference number 
        /// </summary>
		public String ReferenceNum;

        /// <summary>
        /// Order seconary reference (Comes from the channel) 
        /// </summary>
		public String SecondaryReference;

        /// <summary>
        /// Customer full name 
        /// </summary>
		public String cFullName;

        /// <summary>
        /// Return date time 
        /// </summary>
		public DateTime ReturnDate;
	} 
}