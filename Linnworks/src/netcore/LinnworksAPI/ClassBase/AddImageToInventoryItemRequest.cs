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
		public String ItemNumber;

        /// <summary>
        /// pkStockItemId of an item 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Whether you want to set the image as main 
        /// </summary>
		public Boolean IsMain;

        /// <summary>
        /// Image URL 
        /// </summary>
		public String ImageUrl;
	} 
}