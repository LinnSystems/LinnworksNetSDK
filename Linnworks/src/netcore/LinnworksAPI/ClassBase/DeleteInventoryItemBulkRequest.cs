using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteInventoryItemBulkRequest : LinnObject
	{
        /// <summary>
        /// List of items by ids to delete. If not provided, you must provide ItemNumbers 
        /// </summary>
		public List<Guid> InventoryItemIds { get; set; }

        /// <summary>
        /// List of items by item number to delete. If InventoryItemIds is provided, ItemNumbers will be ignored 
        /// </summary>
		public List<String> ItemNumbers { get; set; }
	} 
}