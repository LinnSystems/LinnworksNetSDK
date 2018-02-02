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
		public Int32 BinIndex;

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle;

        /// <summary>
        /// Package name 
        /// </summary>
		public String PackageTitle;

        /// <summary>
        /// Split bin ID 
        /// </summary>
		public Guid pkBinId;

        /// <summary>
        /// Order item row record ID 
        /// </summary>
		public Guid fkOrderItemRowId;

        /// <summary>
        /// Quantity 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Tracking number 
        /// </summary>
		public String TrackingNumber;

        /// <summary>
        /// Item weight 
        /// </summary>
		public Double Weight;
	} 
}