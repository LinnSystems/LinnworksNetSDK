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
		public Guid pkBinId;

        /// <summary>
        /// Postal service ID 
        /// </summary>
		public Guid pkPostalServiceId;

        /// <summary>
        /// Order packaging weight 
        /// </summary>
		public Double PackagingWeight;

        /// <summary>
        /// Order packaging type 
        /// </summary>
		public Guid fkPackagingTypeId;

        /// <summary>
        /// List of items 
        /// </summary>
		public List<OrderPackagingSplitItem> Items;

        /// <summary>
        /// Total weight 
        /// </summary>
		public Double TotalWeight;

        /// <summary>
        /// Tracking number 
        /// </summary>
		public String TrackingNumbers;
	} 
}