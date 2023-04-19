using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OrderItemBase : LinnObject
	{
		public List<ProductIdentifier> ProductIdentifiers { get; set; }

        /// <summary>
        /// Unique stock item id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Stock Keeping Unit 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Main product barcode number 
        /// </summary>
		public String BarcodeNumber { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Quantity on order 
        /// </summary>
		public Int32 Quantity { get; set; }
	} 
}