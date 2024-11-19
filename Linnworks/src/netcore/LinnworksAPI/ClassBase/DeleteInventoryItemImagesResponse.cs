using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteInventoryItemImagesResponse : LinnObject
	{
        /// <summary>
        /// InventoryItemId/StockItemId 
        /// </summary>
		public Guid? InventoryItemId { get; set; }

        /// <summary>
        /// The Item Number (SKU). Only provided if passed in the request 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// Image Id 
        /// </summary>
		public Guid? ImageId { get; set; }
	} 
}