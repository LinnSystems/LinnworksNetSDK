using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Open Order header - Low fidelity 
    /// </summary>
    public class OpenOrderLowFidelity : LinnObject
	{
        /// <summary>
        /// Order items 
        /// </summary>
		public List<OpenOrderItem> Items { get; set; }

        /// <summary>
        /// Order Id - numeric 
        /// </summary>
		public Int32 OrderId { get; set; }

        /// <summary>
        /// Unique order id. 
        /// </summary>
		public Guid pkOrderID { get; set; }

        /// <summary>
        /// Order status as numeric field, 0 - unpaid, 1 - paid, 3 - resend 
        /// </summary>
		public Int32 Status { get; set; }

        /// <summary>
        /// Order reference 
        /// </summary>
		public String ReferenceNum { get; set; }

        /// <summary>
        /// ExternalReference order reference 
        /// </summary>
		public String ExternalReference { get; set; }

        /// <summary>
        /// Tracking number, (of the leading package) 
        /// </summary>
		public String PostalTrackingNumber { get; set; }

        /// <summary>
        /// Order date, UTC time when the order was placed in the system 
        /// </summary>
		public DateTime OrderDate { get; set; }

        /// <summary>
        /// Dispatch by datetime UTC 
        /// </summary>
		public DateTime DispatchBy { get; set; }
	} 
}