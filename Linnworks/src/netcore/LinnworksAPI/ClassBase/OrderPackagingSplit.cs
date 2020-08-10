using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderPackagingSplit
	{
        /// <summary>
        /// Bin ID 
        /// </summary>
		public Guid pkBinId { get; set; }

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId { get; set; }

        /// <summary>
        /// Order packaging weight 
        /// </summary>
		public Decimal PackagingWeight { get; set; }

        /// <summary>
        /// Order packaging type 
        /// </summary>
		public Guid fkPackagingTypeId { get; set; }

        /// <summary>
        /// List of items 
        /// </summary>
		public List<OrderPackagingSplitItem> Items { get; set; }

        /// <summary>
        /// Total weight 
        /// </summary>
		public Decimal TotalWeight { get; set; }

        /// <summary>
        /// Tracking number 
        /// </summary>
		public String TrackingNumbers { get; set; }
	} 
}