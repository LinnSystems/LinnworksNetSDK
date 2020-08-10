using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class VariationItem
	{
        /// <summary>
        /// Variation item record ID 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid pkStockItemId { get; set; }

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle { get; set; }
	} 
}