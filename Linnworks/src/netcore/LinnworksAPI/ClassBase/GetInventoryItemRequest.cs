using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetInventoryItemRequest : LinnObject
	{
        /// <summary>
        /// The Linnworks stock item id.
        /// Used in preference over SKU when supplied 
        /// If not supplied, the SKU will be used 
        /// </summary>
		public Guid? StockItemId { get; set; }

        /// <summary>
        /// The SKU for the item.
        /// Only used when StockItemId is not supplied 
        /// </summary>
		public String SKU { get; set; }
	} 
}