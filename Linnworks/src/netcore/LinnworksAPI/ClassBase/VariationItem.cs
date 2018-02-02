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
		public Guid pkRowId;

        /// <summary>
        /// Stock item ID (unique identifier) 
        /// </summary>
		public Guid pkStockItemId;

        /// <summary>
        /// Item SKU 
        /// </summary>
		public String ItemNumber;

        /// <summary>
        /// Item title 
        /// </summary>
		public String ItemTitle;
	} 
}