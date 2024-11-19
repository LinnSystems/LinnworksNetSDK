using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteInventoryItemImagesRequest : LinnObject
	{
        /// <summary>
        /// The id of the item. If not provided, you must provide ItemNumber 
        /// </summary>
		public Guid? InventoryItemId { get; set; }

        /// <summary>
        /// The item number (SKU) for the item. If InventoryItemId is provided, this will be ignored. 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// A list of images by image ids to delete for the item 
        /// </summary>
		public List<Guid> ImageIds { get; set; }
	} 
}