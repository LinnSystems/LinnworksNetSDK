using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteInventoryItemBulkResponse : LinnObject
	{
        /// <summary>
        /// The ItemNumber (SKU) for the stock item. Only provided if passed in the request 
        /// </summary>
		public String ItemNumber { get; set; }

        /// <summary>
        /// The Id for the stock item. Always provided unless not found 
        /// </summary>
		public Guid? InventoryItemId { get; set; }
	} 
}