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
		public Guid StockItemId { get; set; }

        /// <summary>
        /// ImageId of newly added image 
        /// </summary>
		public Guid ImageId { get; set; }

        /// <summary>
        /// Image new URL 
        /// </summary>
		public String ImageUrl { get; set; }

        /// <summary>
        /// Image Thumbnail URL 
        /// </summary>
		public String ImageThumbnailUrl { get; set; }
	} 
}