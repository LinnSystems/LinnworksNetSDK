using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddImageToInventoryItemResponse
	{
        /// <summary>
        /// pkStockItemId of an item 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// ImageId of newly added image 
        /// </summary>
		public Guid ImageId;

        /// <summary>
        /// Image new URL 
        /// </summary>
		public String ImageUrl;

        /// <summary>
        /// Image Thumbnail URL 
        /// </summary>
		public String ImageThumbnailUrl;
	} 
}