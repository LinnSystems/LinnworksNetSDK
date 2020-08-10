using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Basic stock item information 
    /// </summary>
    public class StockItemInfo
	{
        /// <summary>
        /// Item SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Item unique id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Item Title 
        /// </summary>
		public String ItemTitle { get; set; }

        /// <summary>
        /// Barcode number on the item header 
        /// </summary>
		public String Barcode { get; set; }

        /// <summary>
        /// Image URL 
        /// </summary>
		public String PrimaryImageURL { get; set; }

        /// <summary>
        /// Product identifiers 
        /// </summary>
		public List<StockItemIdentifier> Identifiers { get; set; }
	} 
}