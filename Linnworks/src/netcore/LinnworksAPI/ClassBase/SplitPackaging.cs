using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class SplitPackaging
	{
        /// <summary>
        /// Bin split index 
        /// </summary>
		public Int32 BinIndex { get; set; }

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Package name 
        /// </summary>
		public String PackageTitle { get; set; }

        /// <summary>
        /// Split bin ID 
        /// </summary>
		public Guid pkBinId { get; set; }

        /// <summary>
        /// Order item row record ID 
        /// </summary>
		public Guid fkOrderItemRowId { get; set; }

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Tracking number 
        /// </summary>
		public String TrackingNumber { get; set; }

        /// <summary>
        /// Item weight 
        /// </summary>
		public Double Weight { get; set; }
	} 
}