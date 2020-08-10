using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddImageToInventoryItemRequest
	{
        /// <summary>
        /// SKU number of an item 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// pkStockItemId of an item 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Whether you want to set the image as main 
        /// </summary>
		public Boolean IsMain { get; set; }

        /// <summary>
        /// Image URL 
        /// </summary>
		public String ImageUrl { get; set; }
	} 
}