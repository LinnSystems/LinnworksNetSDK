using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Split Order 
    /// </summary>
    public class OrderSplit : LinnObject
	{
        /// <summary>
        /// Items 
        /// </summary>
		public List<OrderSplitOutItem> Items { get; set; }

        /// <summary>
        /// Postal Service 
        /// </summary>
		public Guid PostalServiceId { get; set; }

		public Boolean ParkOrder { get; set; }
	} 
}